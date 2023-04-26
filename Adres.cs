using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Ogrenci_kayıt_otomasyon
{
    public class Adres
    {
        private string IL;
        private string ILCE;
        private string MAHALLE;
        private int APT_NO;

        public string IL1 { get => IL; set => IL = value; }
        public string ILCE1 { get => ILCE; set => ILCE = value; }
        public string MAHALLE1 { get => MAHALLE; set => MAHALLE = value; }
        public int APT_NO1 { get => APT_NO; set => APT_NO = value; }

        public string Adres_bilgi_ver()
        {
            return "il:" + " " + IL1 + " " + "ilçe" + " " + ILCE1 + " " + "mahalle" + " " + "apartman no:" + " " + APT_NO1;
        }
    }
}