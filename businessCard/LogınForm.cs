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
    public partial class LogınForm : MetroFramework.Forms.MetroForm
    {
        public LogınForm()
        {
            InitializeComponent();
        }

        KisilerDal kisilerDal = KisilerDal.Getİnstace();

        int a = 5;
        Form1 f1 = new Form1();

        public void SifreKontrol(TextBox Username, TextBox Password)
        {
            a -= 1;
            
            kisilerDal.dbConnection.Open();
            OleDbCommand ara = new OleDbCommand("Select Count(*) from Güvenlik where KullanıcıAdı ='" + Username.Text + "'", kisilerDal.dbConnection);
            //     OleDbDataReader ara = komut.ExecuteReader();
            if (ara.ExecuteScalar().ToString() == "1")
            {
                OleDbCommand sifre = new OleDbCommand("Select Sifre from Güvenlik where KullanıcıAdı='" + Username.Text + "'", kisilerDal.dbConnection);
                if (Password.Text == sifre.ExecuteScalar().ToString())
                {
                    kisilerDal.dbConnection.Close();
                    f1.lbl_User.Text = Username.Text;
                    this.Hide();
                    f1.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Şifre Yanlış Kalan deneme Hakkınız  " + a, "Yeniden Dene", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    kisilerDal.dbConnection.Close();
                    if (a == 0)
                    {
                        MessageBox.Show("Deneme Hakkınız Bitti", "Block", MessageBoxButtons.OK, MessageBoxIcon.Information); Application.Exit();
                    }

                }

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı Yanlış Kalan deneme Hakkınız  " + a, "Yeniden Dene", MessageBoxButtons.OK, MessageBoxIcon.Information);
                kisilerDal.dbConnection.Close();
                if (a == 0)
                {
                    MessageBox.Show("Deneme Hakkınız Bitti", "Block", MessageBoxButtons.OK, MessageBoxIcon.Information); Application.Exit();
                }


            }
        }

        private void btn_Logın_Click(object sender, EventArgs e)
        {
            //Access Db den Sifre Kontrol Yapar
            try
            {
                SifreKontrol(txt_username, txt_password);
            }
            catch (Exception)
            {

                MessageBox.Show("Db ye Bağlanılamadı","Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void LogınForm_Load(object sender, EventArgs e)
        {
            txt_username.MaxLength = 30;
            txt_username.MaxLength = 30;
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            if (txt_username.Text == "Username")
            {
                txt_username.Text = "";
                txt_username.ForeColor = Color.FromArgb(64, 64, 64);
                label2.BackColor = Color.FromArgb(85, 162, 182);
            }
        }


        private void txt_password_Enter(object sender, EventArgs e)
        {
            if (txt_password.Text == "Password")
            {
                txt_password.Text = "";
                txt_password.UseSystemPasswordChar = false;
                txt_password.PasswordChar = '*';
                txt_password.ForeColor = Color.FromArgb(64, 64, 64);
                label1.BackColor = Color.FromArgb(85, 162, 182);
            }
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            //0; 174; 219

            if (txt_username.Text == "")
            {
                txt_username.Text = "Username";
                txt_username.ForeColor = Color.Gray;
                label2.BackColor = Color.FromArgb(0, 174, 219);
            }
        }

        private void txt_password_Leave(object sender, EventArgs e)
        {
            if (txt_password.Text == "")
            {
                txt_password.Text = "Password";

                txt_password.UseSystemPasswordChar = true;
                txt_password.ForeColor = Color.Gray;
                label1.BackColor = Color.FromArgb(0, 174, 219);
            }
        }

        private void btn_eye_Click(object sender, EventArgs e)
        {
            if (txt_password.Text != "Password")
            {
                if (txt_password.UseSystemPasswordChar == true)
                {
                    txt_password.UseSystemPasswordChar = false;
                }
                else
                {
                    txt_password.UseSystemPasswordChar = true;
                }
            }

        }



        private void btn_insta_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/angry.eye.code/");
        }

        private void btn_youtube_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCF9-MdUUG7V9ulI96PVolVA");
        }
    }
}
