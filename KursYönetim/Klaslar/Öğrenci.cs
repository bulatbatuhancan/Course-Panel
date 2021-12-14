using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Klaslar
{
    public class Öğrenci
    {
        public enum Meslekler
        {
            ÜnvÖğrencisi,
            LiseÖğrencisi,
            Mühendis,
            Çalışan,
            Diğer
        }




            public int OgrNo;
            public string Adı;
            public string Soyadı;
            public string Eğitim;
            public string KayıtDurumu;
            public string TCno;
            public string Telefon;
            public string Mail;
            public string Cinsiyet;
            public Meslekler Meslek;
            public string Adres;
            public string Hakkında;
            public DateTime DoğumTarihi;
            public string Resim;
            public ÖdemePlanı ödPlanı;
            public string Sertifika;




    }
}
