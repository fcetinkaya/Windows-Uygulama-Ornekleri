using EntityKatmani;
using FacadeKatmani;
using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace Ayakkabi_Imalat_Takip
{
    public partial class OdemelerEkstresi : Form
    {
        public OdemelerEkstresi()
        {
            InitializeComponent();
        }

        private void Listboxdoldur()
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select mkzno,odemeID from Odemeler order by mkzno", connect.connectroad);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listBox1.DataSource = dt;
            listBox1.DisplayMember = "mkzno";
            listBox1.ValueMember = "odemeID";
        }

        private void TedarikciBilgileriniGetir()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select TedarikciID,unvan from tedarikciler WHERE ((tedarikciler.IsActive)=True) order by unvan", connect.connectroad);
            DataTable dtt = new DataTable();
            dap.Fill(dtt);
            DataRow dr = dtt.NewRow();
            dr["unvan"] = "Lütfen Seçiniz";
            dtt.Rows.InsertAt(dr, 0);
            tdrikcicombo.DataSource = dtt;
            tdrikcicombo.ValueMember = "TedarikciID";
            tdrikcicombo.DisplayMember = "unvan";
        }

        private void ListviewDoldur()
        {
            listView1.Items.Clear();
            FOdemeler Odemeci = new FOdemeler();
            DataTable dt = Odemeci.OEkstre();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                double tutarimiz = Convert.ToDouble(dt.Rows[i]["tutar"].ToString());
                string tutar = String.Format("{0:C}", tutarimiz);
                //yada
                //string tutar=tutarimiz.ToString("C"); TL Olarak verir
                //string tutar=tutarimiz.ToString("N"); TL Vermez
                ListViewItem tahsilato = new ListViewItem(dt.Rows[i]["mkzno"].ToString());
                tahsilato.SubItems.Add(dt.Rows[i]["tarih"].ToString().Remove(11));
                tahsilato.SubItems.Add(tutar);
                tahsilato.SubItems.Add(dt.Rows[i]["unvan"].ToString());
                tahsilato.SubItems.Add(dt.Rows[i]["aciklama"].ToString());
                listView1.Items.Add(tahsilato);
            }
        }

        private bool tedarikcidegistimiula = false;

        private void OdemelerEkstresi_Load(object sender, EventArgs e)
        {
            ListviewDoldur();
            TedarikciBilgileriniGetir();
            Listboxdoldur();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tdrikcicombo.SelectedIndex == 0)
            {
                MessageBox.Show("Lütfen Tedarikci İçin Bir Firma Seçiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
            {
                listView1.Items.Clear();
                EOdemeler Odemeler = new EOdemeler();
                Odemeler.TedarikciID = Convert.ToInt32(tdrikcicombo.SelectedValue);
                //FTahsilat.TEkstreByMusteri(Emusteri);
                DataTable det = FOdemeler.OEkstreByTedarikci(Odemeler);
                if (det.Rows.Count != 0)
                {
                    for (int i = 0; i < det.Rows.Count; i++)
                    {
                        double tutarimiz = Convert.ToDouble(det.Rows[i]["tutar"].ToString());
                        string tutar = String.Format("{0:C}", tutarimiz);
                        ListViewItem tahsilamusteri = new ListViewItem(det.Rows[i]["mkzno"].ToString());
                        tahsilamusteri.SubItems.Add(det.Rows[i]["tarih"].ToString().Remove(11));
                        tahsilamusteri.SubItems.Add(tutar);
                        tahsilamusteri.SubItems.Add(det.Rows[i]["unvan"].ToString());
                        tahsilamusteri.SubItems.Add(det.Rows[i]["aciklama"].ToString());
                        listView1.Items.Add(tahsilamusteri);
                    }
                }
                else
                {
                    MessageBox.Show("İlgili Tedarikci Hakkında Kayıt Bulunamamıştır !", "Arama Sonuç", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ListviewDoldur();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbDataAdapter da = new OleDbDataAdapter("select * from Odemeler WHERE ((Odemeler.mkzno) like @mkz)", connect.connectroad);
            da.SelectCommand.Parameters.AddWithValue("@mkz", textBox1.Text + "%");
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {
                listBox1.DataSource = dt;
                listBox1.DisplayMember = "mkzno";
                listBox1.ValueMember = "odemeID";
                listBox1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                MessageBox.Show(" " + textBox1.Text + " " + "Numaralı Ödeme Makbuzu Bulunamamıştır. !");
                ListviewDoldur();
            }
            textBox1.Text = string.Empty;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tedarikcidegistimiula = true;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (tedarikcidegistimiula == true)
            {
                listView1.Items.Clear();
            }
            EOdemeler Etedarikci = new EOdemeler();
            Etedarikci.odemeID = Convert.ToInt32(listBox1.SelectedValue);
            DataTable det = FOdemeler.OEkstreBymkzno(Etedarikci);
            for (int i = 0; i < det.Rows.Count; i++)
            {
                double tutarimiz = Convert.ToDouble(det.Rows[i]["tutar"].ToString());
                string tutar = String.Format("{0:C}", tutarimiz);
                ListViewItem tahsilatedarikci = new ListViewItem(det.Rows[i]["mkzno"].ToString());
                tahsilatedarikci.SubItems.Add(det.Rows[i]["tarih"].ToString().Remove(11));
                tahsilatedarikci.SubItems.Add(tutar);
                tahsilatedarikci.SubItems.Add(det.Rows[i]["unvan"].ToString());
                tahsilatedarikci.SubItems.Add(det.Rows[i]["aciklama"].ToString());
                listView1.Items.Add(tahsilatedarikci);
            }
        }
    }
}