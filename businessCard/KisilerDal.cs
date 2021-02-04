using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace businessCard
{
    public class KisilerDal : IDataBase
    {
        public static string adres = System.IO.File.ReadAllText(@"C:\DB.txt");
   
        public OleDbConnection dbConnection = new OleDbConnection(adres);
        
       //  public OleDbConnection dbConnection = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\WIN7\Documents\BusinessCardDb.accdb;User ID=admin");
       
        //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\WIN7\Documents\BusinessCardDb.accdb;User ID=admin
        private static KisilerDal _instace;

        private KisilerDal(){ }

        public static KisilerDal Getİnstace()
        {
        
            if (_instace == null)
            {
                _instace = new KisilerDal();
            }
            return _instace;
        }


        // Access Bağlantı Adresi

        DataTable tablo;

        public void Save_Delete_Update(OleDbCommand komut, string sorgu)
        {
            dbConnection.Open();
            komut.Connection = dbConnection;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            dbConnection.Close();
        }

        public void add(Kisiler kişiler)
        {

            dbConnection.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kisiler (Meslek,İsimSoyisim,Tel,Mail,Konu,Ceptel,Tarih) values (@Meslek,@İsimSoyisim,@Tel,@Mail,@Konu,@Ceptel,@Tarih)", dbConnection);

            komut.Parameters.AddWithValue("@Meslek", kişiler.Meslek);
            komut.Parameters.AddWithValue("@İsimSoyisim", kişiler.İsimSoyisim);
            komut.Parameters.AddWithValue("@Tel", kişiler.Tel);
            komut.Parameters.AddWithValue("@Mail", kişiler.Mail);
            komut.Parameters.AddWithValue("@Konu", kişiler.Konu);
            komut.Parameters.AddWithValue("@Ceptel", kişiler.Ceptel);
            komut.Parameters.AddWithValue("@Tarih", kişiler.Tarih);
            komut.ExecuteNonQuery();
            dbConnection.Close();

        }

        public void Update(Kisiler kişiler)
        {

            dbConnection.Open();
            OleDbCommand komut = new OleDbCommand("Update  Kisiler set Meslek = @Meslek , İsimSoyisim = @İsimSoyisim , Tel = @Tel , Mail = @Mail , Konu =@Konu , Ceptel =@Ceptel  where Mail = @Mail", dbConnection);

            komut.Parameters.AddWithValue("@Meslek", kişiler.Meslek);
            komut.Parameters.AddWithValue("@İsimSoyisim", kişiler.İsimSoyisim);
            komut.Parameters.AddWithValue("@Tel", kişiler.Tel);
            komut.Parameters.AddWithValue("@Mail", kişiler.Mail);
            komut.Parameters.AddWithValue("@Konu", kişiler.Konu);
            komut.Parameters.AddWithValue("@Ceptel", kişiler.Ceptel);

            komut.ExecuteNonQuery();
            dbConnection.Close();


        }

        public DataTable Refresh(OleDbDataAdapter adtr, string sorgu)
        {
            dbConnection.Open();
            tablo = new DataTable();
            adtr = new OleDbDataAdapter(sorgu, dbConnection);
            adtr.Fill(tablo);
            dbConnection.Close();
            return tablo;
        }

    }
}
