using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace businessCard
{
    public partial class MailGönderForm : MetroFramework.Forms.MetroForm
    {
        public MailGönderForm()
        {
            InitializeComponent();
        }

        public string hotmail = "smtp.live.com";
        public string gmail = "smtp.gmail.com";
        public string outlock = "smtp-mail.outlook.com";

        public void Mail(string Mail, string Kime)
        {
            try
            {
                string GönderenMail = txt_GönderenAd.Text;
                string GönderenSifre = txt_GönderenSifre.Text;


                MailMessage message = new MailMessage();
                SmtpClient istemci = new SmtpClient();
                istemci.Credentials = new System.Net.NetworkCredential(GönderenMail, GönderenSifre); // gönderen
                istemci.Port = 587;
                istemci.Host = Mail; // smtp.gmail.com
                istemci.EnableSsl = true;
                message.To.Add(Kime);
                message.From = new MailAddress(GönderenMail);//Gönderilen
                message.Subject = txt_Baslık.Text;
                message.Body = txt_İçerik.Text;
                istemci.Send(message);


            }
            catch (Exception)
            {

                MessageBox.Show("Mail Gönderirken Hata Oluştu Tekrar Deneyiniz Yada Diğer Butonlar İle Gönderiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void Sil()
        {
            foreach (Control item in Controls) if (item is TextBox || item is ComboBox) item.Text = null;
        }
        private void MailGönderForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_MailGönder_Click(object sender, EventArgs e)
        {
            string kime = txt_mailAdress.Text;
            Mail(hotmail, kime);
            Sil();

        }

        private void txt_GmaileGönder_Click(object sender, EventArgs e)
        {
            string kime = txt_mailAdress.Text;
            Mail(gmail, kime);
            Sil();
        }

        private void btn_outlock_Click(object sender, EventArgs e)
        {
            string kime = txt_mailAdress.Text;
            Mail(outlock, kime);
            Sil();
        }
    }
}
