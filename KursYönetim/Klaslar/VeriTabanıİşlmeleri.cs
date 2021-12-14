using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;  // mssql ile ilgili komutlar bu namespace içinde.
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Runtime.InteropServices;
using System.Data.Common;

namespace Klaslar
{

   //string komut = "update tblKullanıcılar set KullanıcıAdı = '"+ kul.KullanıcıAdı + "', Şifre ='"+kul.Şifre+"', Mail ='"+kul.Mail+"',Admin='" + kul.Admin + "' where ID = '"+kul.ID+"' " ;




    public class VeriTabanıİşlmeleri
    {
        // bağlanacağımız sql server ve database'i tanımlayalım.

        string DByolu = "data source = BULAT ; database = ÖğrenciYönetimi2020 ; Integrated Security = SSPI";

        public static bool Admin = false;







        public DataSet ÖğrenciListesi()
        {
            string komut = "select * from tblÖğrenciBilgileri";

            SqlConnection con = new SqlConnection(DByolu);
            SqlCommand cmd = new SqlCommand(komut, con);
            DataSet ds = new DataSet();

            con.Open();

            // Adapter sql den bir tablo alır.

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            // adapter sqlden aldığı tabloyu 

            da.Fill(ds);

            return ds;



        }


        public bool KullanıcıVarMı(string Kullanıcı, string Şifre)
        {
            // SQL ile C# arasında bir yol açalım SQL connection


            SqlConnection con = new SqlConnection(DByolu);

            // Kullanıcı Check eden komutu yazalım

            string Komut = " select Admin from tblKullanıcılar where KullanıcıAdı ='" + Kullanıcı + "' and Şifre ='" + Şifre + "'";

            // SQL komutunu hazırlayalım.

            SqlCommand cmd = new SqlCommand(Komut, con);

            con.Open();

            object obj;

            obj = cmd.ExecuteScalar();

            if (obj != null)
            {
                Admin = (bool)obj;
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }


        }


        public bool KullanıcıEkle(Kullanıcı kul)
        {
            string komut = "INSERT INTO tblKullanıcılar(KullanıcıAdı,Şifre,Mail,Admin)values('"+kul.KullanıcıAdı+"', '"+kul.Şifre+"', '"+kul.Mail+"','" +kul.Admin+ "')";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            return true;

        }
 

        public DataTable KullanıcıListesi()
        {
            string komut = "select * from tblKullanıcılar";

            SqlConnection con = new SqlConnection(DByolu);

            DataTable dt = new DataTable();
      

            SqlCommand cmd = new SqlCommand(komut, con);

            con.Open();

                // sqlden bir tablo gelecek. 
                // sqlden eğer tablo ya da bir tablo satırı gelirse executeReader ve sqlDataRedaer kullanılır.

            SqlDataReader rd;

            rd = cmd.ExecuteReader();

            dt.Load(rd); // rd gelen tabloyu okur ve tanımladığımız tablonun içine atar

            con.Close();

            return dt;

        }


        public bool KullanıcıGüncelle(Kullanıcı kul)
        {
            string komut = "update tblKullanıcılar set KullanıcıAdı = '" + kul.KullanıcıAdı + "', Şifre ='" + kul.Şifre + "', Mail ='" + kul.Mail + "',Admin='" + kul.Admin + "' where Id = '" + kul.Id + "' ";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            return true;

        }


        public bool KullanıcıSil(int Id)
        {
            string komut = "delete tblKullanıcılar where Id='" + Id + "'";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();

            return true;



        }


        public bool ÖğrenciBilgisiEkle(Öğrenci ogr)
        {

            // kullanıcı bilgilerini SQL e göndereceğiz 

            //string komut = "INSERT INT tblKullanıcılar(KullanıcıAdı = '" + kul.KullanıcıAdı + "'," + "Şifre = '" + kul.Şifre + "',Mail = '" + kul.Mail + "',Admin = '" + kul.Admin + "')";




            SqlConnection con = new SqlConnection(DByolu);

            string komut = "spÖğrenciBilgisiEkle";

            bool HataYok = true;

            con.Open();

            SqlTransaction tr = con.BeginTransaction();


            try
            {


                String maxOgrKomutu = "select max(OgrNo) from tblÖğrenciBilgileri";

                SqlCommand cmd1 = new SqlCommand(maxOgrKomutu, con, tr);

                object maxOgrNo = cmd1.ExecuteScalar();

                if (maxOgrNo != DBNull.Value)
                {
                    ogr.OgrNo = (int)maxOgrNo + 1;
                }
                else
                {
                    ogr.OgrNo = 1;
                }
                con.Close();


                SqlCommand cmd = new SqlCommand(komut, con, tr);

                cmd.CommandType = CommandType.StoredProcedure;



                cmd.Parameters.Add("@OgrNo", ogr.OgrNo);
                cmd.Parameters.Add("@Adı", ogr.Adı);
                cmd.Parameters.Add("@Soyadı", ogr.Soyadı);
                cmd.Parameters.Add("@Eğitim", ogr.Eğitim);
                cmd.Parameters.Add("@KayıtDurumu", ogr.KayıtDurumu);
                cmd.Parameters.Add("@TCNo", ogr.TCno);
                cmd.Parameters.Add("@Telefon", ogr.Telefon);
                cmd.Parameters.Add("@Mail", ogr.Mail);
                cmd.Parameters.Add("@Cinsiyet", ogr.Cinsiyet);
                cmd.Parameters.Add("@Meslek", ogr.Meslek.ToString());
                cmd.Parameters.Add("@Adres", ogr.Adres);
                cmd.Parameters.Add("@DoğumTarihi", ogr.DoğumTarihi);
                cmd.Parameters.Add("@Hakkında", ogr.Hakkında);
                cmd.Parameters.Add("@Resim", ogr.Resim);
                cmd.Parameters.Add("@Sertifika", ogr.Sertifika);


                con.Open();

                cmd.ExecuteNonQuery();



                if (ogr.ödPlanı != null)
                {



                    string öpKomut = "spÖdemePlanıEkle";

                    SqlCommand cmd2 = new SqlCommand(öpKomut, con, tr);

                    cmd2.CommandType = CommandType.StoredProcedure;

                    string odb = ogr.ödPlanı.ÖdemeBiçimi.ToString();

                    cmd2.Parameters.Add("@OgrNo", ogr.OgrNo);
                    cmd2.Parameters.Add("@ToplamTutar", (decimal)ogr.ödPlanı.ToplamTutar);
                    cmd2.Parameters.Add("@Peşinat", (decimal)ogr.ödPlanı.Peşinat);
                    cmd2.Parameters.Add("@ÖdemeBiçimi", odb);
                    cmd2.Parameters.Add("@TaksitSayısı", ogr.ödPlanı.TaksitSayısı);
                    cmd2.Parameters.Add("@İlkÖdemeTarihi", ogr.ödPlanı.İlkÖdemeTarihi);

                    cmd2.ExecuteNonQuery();

                    DataTable dt = ogr.ödPlanı.Taksitler;

                    komut = "spTaksitEkle";

                    cmd2 = new SqlCommand(komut, con, tr);

                    cmd2.CommandType = CommandType.StoredProcedure;

                    cmd2.Parameters.Add("@Taksitler", dt);
                    cmd2.Parameters.Add("@OgrNo", ogr.OgrNo);

                    cmd2.ExecuteNonQuery();

                    tr.Commit();


                }

            }

            catch (Exception ex)
            {
                HataYok = false;

                string hata = ex.Message;

                tr.Rollback();
            }
            finally
            {
                con.Close();

            }


            return HataYok;





        }


        public bool ÖdemePlanıEkle(ÖdemePlanı ödPlanı,int OgrNo)
        {
            SqlConnection con = new SqlConnection(DByolu);

            bool HataYok = true;

            con.Open();

            SqlTransaction tr = con.BeginTransaction();

            string komut = "";

            try
            {

                if (ödPlanı != null)
                {



                    string öpKomut = "spÖdemePlanıEkle";

                    SqlCommand cmd1 = new SqlCommand(öpKomut, con, tr);

                    cmd1.CommandType = CommandType.StoredProcedure;

                    string odb = ödPlanı.ÖdemeBiçimi.ToString();

                    cmd1.Parameters.Add("@OgrNo",OgrNo);
                    cmd1.Parameters.Add("@ToplamTutar", (decimal)ödPlanı.ToplamTutar);
                    cmd1.Parameters.Add("@Peşinat", (decimal)ödPlanı.Peşinat);
                    cmd1.Parameters.Add("@ÖdemeBiçimi", odb);
                    cmd1.Parameters.Add("@TaksitSayısı", ödPlanı.TaksitSayısı);
                    cmd1.Parameters.Add("@İlkÖdemeTarihi", ödPlanı.İlkÖdemeTarihi);

                    cmd1.ExecuteNonQuery();




                    DataTable dt = ödPlanı.Taksitler;

                    komut = "spTaksitEkle";

                    cmd1 = new SqlCommand(komut, con, tr);

                    cmd1.CommandType = CommandType.StoredProcedure;

                    cmd1.Parameters.Add("@Taksitler", dt);

                    cmd1.Parameters.Add("@OgrNo", OgrNo);

                    cmd1.ExecuteNonQuery();

                    tr.Commit();

                }


            }
            catch (Exception)
            {
                HataYok = false;
                tr.Rollback();
            }
            finally
            {
                con.Close();
            }

            return HataYok;



        }


        public bool ÖğrenciGüncelle(Öğrenci ogr)
        {
            string komut = "spÖğrenciBilgileriGüncelle";

            bool GüncellendiMi = true;

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@OgrNo", ogr.OgrNo);
            cmd.Parameters.Add("@Adı", ogr.Adı);
            cmd.Parameters.Add("@Soyadı", ogr.Soyadı);
            cmd.Parameters.Add("@Eğitim", ogr.Eğitim);
            cmd.Parameters.Add("@KayıtDurumu", ogr.KayıtDurumu);
            cmd.Parameters.Add("@TCNo", ogr.TCno);
            cmd.Parameters.Add("@Telefon", ogr.Telefon);
            cmd.Parameters.Add("@Mail", ogr.Mail);
            cmd.Parameters.Add("@Cinsiyet", ogr.Cinsiyet);
            cmd.Parameters.Add("@Meslek", ogr.Meslek.ToString());
            cmd.Parameters.Add("@Adres", ogr.Adres);
            cmd.Parameters.Add("@DoğumTarihi", ogr.DoğumTarihi);
            cmd.Parameters.Add("@Hakkında", ogr.Hakkında);
            cmd.Parameters.Add("@Resim", ogr.Resim);
            cmd.Parameters.Add("@Sertifika", ogr.Sertifika.ToString());

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();


            return GüncellendiMi;

        }


        public DataTable TaksitleriGetir(int OgrNo, string TabloAdı)
        {
            string komut = "";

            if (TabloAdı == "tblTaksitler")
            {
                komut = "select * from tblTaksitler where OgrNo='" + OgrNo + "' ";
            }
            else if(TabloAdı == "tblÖdenmişTaksitler")
            {
                komut = "select * from tblTaksitler where OgrNo='" + OgrNo + "' ";
            }



            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut,con);

            DataTable dt = new DataTable();

            SqlDataReader rd;

            con.Open();

            try
            {
                rd = cmd.ExecuteReader();

                dt.Load(rd);
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.Close();
            }







            return dt;

        }

    
        public bool ÖdemeYap(int OgrNo, int TaksitNo)
        {
            bool ok = false;

            string komut = "update tblTaksitler set TaksitMiktarı = 0, ÖdemeDurumu = 'Ödendi' " + "where OgrNo ='" + OgrNo + "' and TaksitNo ='" + TaksitNo + "'";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ok = true;
            }
            catch (Exception)
            {
                ok = false;
                con.Close();
            }

            return ok;

        }


        public bool ÖdemeYap(int OgrNo, int TaksitNo, int Kalan)
        {
            bool ok = false;

            string komut = "update tblTaksitler set TaksitMiktarı ='" + Kalan + "' " + "where OgrNo ='" + OgrNo + "' and TaksitNo ='" + TaksitNo + "'";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                ok = true;
            }
            catch (Exception)
            {
                ok = false;
                con.Close();
            }

            return ok;

        }


        public bool ÖğrenciSil(int OgrNo)
        {
            bool SilOk = false;

            string komut = "delete tblÖğrenciBilgileri where OgrNo='" + OgrNo + "'";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                SilOk = true;
            }
            catch (Exception)
            {
                SilOk = false;
            }
            finally
            {
                con.Close();
            }

            return SilOk;
            
        }


        public DataTable ÖğrenciMailleri()
        {
            DataTable dt = new DataTable();

            string komut = " select Adı , Soyadı , Mail from tblÖğrenciBilgileri ";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            con.Close();

            return dt;
        }


        public DataTable Ödenmemişler()
        {
            string komut = "spÖdenmemişler";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            con.Close();

            return dt;


        }


        public DataTable EğitimGelirleri()
        {
            string komut = "spEğitimGelirleri";

            SqlConnection con = new SqlConnection(DByolu);

            SqlCommand cmd = new SqlCommand(komut, con);

            cmd.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();

            con.Open();

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);

            con.Close();

            return dt;


        }





    }





    
}



