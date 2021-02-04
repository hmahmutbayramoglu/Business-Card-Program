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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Kişilerdal ı Kullanacağım için instace çağırıyruz bu şekilde gereksiz fazladan yenilemeyi önler
        KisilerDal kisilerDal = KisilerDal.Getİnstace();

        public void refresh()
        {
            string Yenile = "Select *from Kisiler";
            OleDbDataAdapter adtr = new OleDbDataAdapter();
            dataGridView1.DataSource = kisilerDal.Refresh(adtr, Yenile);
            int a = dataGridView1.RowCount - 1;
            lbl_KayıtSayısı.Text = a.ToString();

        }

        public void KisileriGöster()
        {
            RegistrationPanelForm f = new RegistrationPanelForm();
            f.txt_mail.Enabled = false;

            if (dataGridView1.SelectedRows.Count > 0)
            {

                f.txt_isimsoyisim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                f.txt_meslek.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                f.txt_tel.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                f.txt_mail.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                f.txt_ceptel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                f.txt_konu.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                f.btn_kaydet.Visible = false;
                f.ShowDialog();


            }
            else
            {
                MessageBox.Show("lütfen kişi seçin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        public void TümSil()
        {
            try
            {
                MessageBox.Show(lbl_KayıtSayısı.Text + " Adet kayıt Silindi ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string Sil = "Delete from Kisiler";
                OleDbCommand kmt = new OleDbCommand();
                kisilerDal.Save_Delete_Update(kmt, Sil);

            }
            catch (Exception)
            {
                MessageBox.Show("Error 'TS' Lütfen Bu Hatayı Programcınıza Bildirin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void TekSil()
        {
            try
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    OleDbCommand komut = new OleDbCommand();
                    string Sil = "delete from Kisiler where İsimSoyisim ='" + dataGridView1.SelectedRows[i].Cells[1].Value + "' ";
                    kisilerDal.Save_Delete_Update(komut, Sil);
                }
                MessageBox.Show(dataGridView1.SelectedRows.Count + " Adet kayıt Silindi ", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Error 'TK' Lütfen Bu Hatayı Programcınıza Bildirin", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void Ara(TextBox text)
        {
            string İsim = "Select *from Kisiler Where Meslek like '" + text.Text + "%' or  İsimSoyisim like '" + text.Text + "%'";
            OleDbDataAdapter adtr1 = new OleDbDataAdapter();
            dataGridView1.DataSource = kisilerDal.Refresh(adtr1, İsim);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //DataBase Refresh
            refresh();
        }

        private void btn_KayıtPaneli_Click(object sender, EventArgs e)
        {
            //Kayıt Panelini Açar
            RegistrationPanelForm f = new RegistrationPanelForm();
            f.btn_mail.Visible = false;
            f.btn_güncelle.Visible = false;
            f.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Seçilen Satırdaki Kişinin Bilgilerini RegistrationPanelin deki Textboxlara Doldurur
            KisileriGöster();
        }

        private void btn_Güncelle_Click(object sender, EventArgs e)
        {
            //Verileri Yeniler
            refresh();
        }

        SilmeOnayForm fs = new SilmeOnayForm();
        public bool SilmeOnay;

        private void btn_TümSil_Click(object sender, EventArgs e)
        {
            if (fs.Onay == false)
            {
                fs.Name = "deneme";
                if (Application.OpenForms["deneme"] == null)
                {
                    fs.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show(lbl_KayıtSayısı.Text+" Kayıt Silinecek Onaylıyormusunuz ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Datagrid deki Seçilen Satırlari Siler 1 den fazlada silebilir
                    TümSil();
                    //Verileri Yeniler
                    refresh();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi", "İPTAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // MessageBox.Show("Silme İşlemi İçin Onayınız Yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }



        }
            

        
       

        private void btn_Sil_Click(object sender, EventArgs e)
        {

            if (fs.Onay == false)
            {
                fs.Name = "deneme";
                if (Application.OpenForms["deneme"] == null)
                {
                    fs.ShowDialog();
                }
            }
            else
            {
                if (MessageBox.Show("Seçilen Kayıtlar Silinecek Onaylıyormusun ?", "Onay Verin", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //Datagrid deki Seçilen Satırlari Siler 1 den fazlada silebilir
                    TekSil();
                    //Verileri Yeniler
                    refresh();
                }
                else
                {
                    MessageBox.Show("Silme İşlemi İptal Edildi", "İPTAL", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                // MessageBox.Show("Silme İşlemi İçin Onayınız Yok", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void txt_ara_TextChanged(object sender, EventArgs e)
        {
            //İsimSoyisim ,Meslek Ve Tel E göre Arama Yapar
            Ara(txt_ara);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            İnfo i = new İnfo();
            i.ShowDialog();
        }
    }
}
