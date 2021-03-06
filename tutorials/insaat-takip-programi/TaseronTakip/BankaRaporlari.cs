using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TaseronTakip
{
    public partial class BankaRaporlari : Form
    {
        public BankaRaporlari()
        {
            InitializeComponent();
        }
        public static string SeciliKasa = null;
        public static string IlkTarih = "";
        public static string IkinciTarih = "";
        OleDbConnection con = new OleDbConnection(connect.connectroad);
        public void GiderKasa()
        {
            OleDbDataAdapter dap = new OleDbDataAdapter("select * from Kasa where ((Kasa.IsActive)=True) order by Kod", con);
            DataTable dt = new DataTable();
            dap.Fill(dt);
            if (dt != null)
            {
                DataRow dr = dt.NewRow();
                dr["Tanim"] = "Lütfen Seçiniz";
                dt.Rows.InsertAt(dr, 0);
                kasacombo.DataSource = dt;
                kasacombo.DisplayMember = "Tanim";
                kasacombo.ValueMember = "KasaID";
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            tarih1box.Text = dateTimePicker1.Value.ToString();
        }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            Tarih2box.Text = dateTimePicker2.Value.ToString();
        }
        private void Raporlabtn_Click(object sender, EventArgs e)
        {
            if (kasacombo.Text != "Lütfen Seçiniz")
            {
                SeciliKasa = kasacombo.SelectedValue.ToString();
                IlkTarih = tarih1box.Text;
                IkinciTarih = Tarih2box.Text;
                RaporlarKasaBanka RKN = new RaporlarKasaBanka();
                RKN.ShowDialog();
            }
            else
            {
                MessageBox.Show("Kasa Seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        private void BankaRaporlari_Load(object sender, EventArgs e)
        {
            GiderKasa();
        }
    }
}
