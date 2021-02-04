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
    public partial class RegistrationPanelForm : MetroFramework.Forms.MetroForm
    {
        public RegistrationPanelForm()
        {
            InitializeComponent();
        }

        //Kişiler Classı nın Tekrar Tekrar Yenilenmesini Önler Birden Fazla Yenilemez 
        KisilerDal kisilerDal = KisilerDal.Getİnstace();

        //Eğer Kayıtlı Kişiyi Birdaha Kayıt etmek istersek true olur ve Hata verir
        bool Durum;
        public void mükerrer()
        {
            kisilerDal.dbConnection.Open();
            OleDbCommand cmd = new OleDbCommand("Select *from Kisiler where İsimSoyisim = @İsimSoyisim", kisilerDal.dbConnection);
            cmd.Parameters.AddWithValue("@İsimSoyisim", txt_isimsoyisim.Text);
            OleDbDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Durum = false;
            }
            else
            {
                Durum = true;
            }

            kisilerDal.dbConnection.Close();
        }

        //AccessDb BusinessCard Veri Tabanına Kisiler Tablosuna Kayıt Yapar
        public void Add()
        {

            kisilerDal.add(new Kisiler
            {
                İsimSoyisim = txt_isimsoyisim.Text,
                Tel = txt_tel.Text,
                Ceptel = txt_ceptel.Text,
                Mail = txt_mail.Text,
                Konu = txt_konu.Text,
                Meslek = txt_meslek.Text,
                Tarih = DateTime.Now.ToString()
            });
        }

        //AccessDb BusinessCard Veri Tabanına Seçilen Kişiye Kisiler Tablosunda Güncelleme Yapar
        public void Güncelle()
        {
            Kisiler kisiler = new Kisiler
            {
                İsimSoyisim = txt_isimsoyisim.Text,
                Tel = txt_tel.Text,
                Ceptel = txt_ceptel.Text,
                Mail = txt_mail.Text,
                Konu = txt_konu.Text,
                Meslek = txt_meslek.Text
            };
            kisilerDal.Update(kisiler);
        }

        //TextBoxları Ve ComboBoxları Temizler
        public void Sil()
        {
            foreach (Control item in Controls) if (item is TextBox || item is ComboBox) item.Text = null;
        }


        public void maxlenght()
        {
            txt_isimsoyisim.MaxLength = 30;
            txt_meslek.MaxLength = 20;
            txt_tel.MaxLength = 11;
            txt_ceptel.MaxLength = 11;
            txt_mail.MaxLength = 25;
            txt_konu.MaxLength = 200;
        }


        private void RegistrationPanelForm_Load(object sender, EventArgs e)
        {
            maxlenght();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //Kayıt Kontrol Durum Değişkenini Kontrol Eder
                mükerrer();
                if (Durum == true)
                {
                    //Kayıtlı Değilse Kayıt Eder
                    Add();
                    pictureBox1.Visible = true;
                    lbl_Bilgi.Text = txt_isimsoyisim.Text + " Kişisi Kayıt Edildi ";
                    //TextBoxları Ve ComboBoxları Temizler
                    Sil();
                }
                else
                {
                    MessageBox.Show(txt_isimsoyisim.Text + " Kişisi Zaten Kayıtlı", "Dikkat", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            { MessageBox.Show("Hata Add","Hata",MessageBoxButtons.OK,MessageBoxIcon.Error); }

        }

        private void btn_güncelle_Click(object sender, EventArgs e)
        {
            //AccessDb Update
            Güncelle();
            pictureBox1.Visible = true;
            lbl_Bilgi.Text = txt_isimsoyisim.Text + " Kişisi Güncellendi Edildi ";
        }

        private void txt_isimsoyisim_TextChanged(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true)
            {
                pictureBox1.Visible = false;
                lbl_Bilgi.Text = "";
            }
        }

        private void btn_mail_Click(object sender, EventArgs e)
        {
            //Mail Gönderme Formu
            //Kodları Yukarıdan Aşşağıya Okuduğu için görmedi
            MailGönderForm f = new MailGönderForm();
            f.txt_mailAdress.Text = txt_mail.Text;
            f.txt_mailAdress.Enabled = false;
            f.ShowDialog();
        }
    }
}
