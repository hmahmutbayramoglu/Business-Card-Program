using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace businessCard
{
    public partial class SilmeOnayForm : MetroFramework.Forms.MetroForm
    {
        public SilmeOnayForm()
        {
            InitializeComponent();
        }

        KisilerDal kisilerDal = KisilerDal.Getİnstace();

        private void SilmeOnayForm_Load(object sender, EventArgs e)
        {

        }

        public bool Onay = false;
        public void LogınControl()
        {
            kisilerDal.dbConnection.Open();
            OleDbCommand ara = new OleDbCommand("Select Count(*) from SilmeOnay where KullanıcıAdı ='" + txt_OnayUsername.Text + "'", kisilerDal.dbConnection);
            //     OleDbDataReader ara = komut.ExecuteReader();
            if (ara.ExecuteScalar().ToString() == "1")
            {
                OleDbCommand sifre = new OleDbCommand("Select Sifre from SilmeOnay where KullanıcıAdı='" + txt_OnayUsername.Text + "'", kisilerDal.dbConnection);
                if (txt_OnayPassword.Text == sifre.ExecuteScalar().ToString())
                {
                    kisilerDal.dbConnection.Close();
                    Onay = true;
                    this.Close();
                    MessageBox.Show("Silme İşlemleri İçin Onay Verildi", "Onay Verildi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Onay = false;
                    MessageBox.Show("Hatalı Giriş ", "Yeniden Dene", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kisilerDal.dbConnection.Close();
                }
            }
            else
            {
                MessageBox.Show("Hatalı Giriş ", "Yeniden Dene", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kisilerDal.dbConnection.Close();
            }

        }

        private void btn_Onay_Click(object sender, EventArgs e)
        {
            LogınControl();
           
        }
    }
}
