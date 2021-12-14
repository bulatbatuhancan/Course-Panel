using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 


namespace Klaslar
{

    public enum ÖdemeBiçimi
    {
        Peşin,
        Taksitli

    }


    public class ÖdemePlanı
    {

        public ushort ToplamTutar;
        public ushort Peşinat;
        public ÖdemeBiçimi ÖdemeBiçimi;
        public byte TaksitSayısı;
        public DateTime İlkÖdemeTarihi;
        public DataTable Taksitler;
    }
}
