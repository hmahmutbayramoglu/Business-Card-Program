using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace businessCard
{
    public class Kisiler
    {
        private string _isimsoyisim;

        private string _meslek;

        private string _tel;

        private string _mail;

        private string _konu;

        private string _ceptel;

        private string _tarih;

        public string Tarih { get { return _tarih; } set { _tarih = value; } }

        public string İsimSoyisim { get { return _isimsoyisim; } set { _isimsoyisim = value; } }

        public string Meslek { get { return _meslek; } set { _meslek = value; } }

        public string Tel { get { return _tel; } set { _tel = value; } }

        public string Mail { get { return _mail; } set { _mail = value; } }

        public string Konu { get { return _konu; } set { _konu = value; } }

        public string Ceptel { get { return _ceptel; } set { _ceptel = value; } }




    }
}
