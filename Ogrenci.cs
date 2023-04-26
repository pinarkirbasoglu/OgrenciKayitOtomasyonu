using System;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.ComponentModel;

namespace Ogrenci_kayıt_otomasyon
{
    public class Ogrenci
    {
        private string AD;
        private string SOYAD;
        private int OGR_NO;
        private Adres MEMLEKET;
        private Adres IKAMETGAH;

        public string AD1 { get => AD; set => AD = value; }
        public string SOYAD1 { get => SOYAD; set => SOYAD = value; }
        public int OGR_NO1 { get => OGR_NO; set => OGR_NO = value; }
        public Adres MEMLEKET1 { get => MEMLEKET; set => MEMLEKET = value; }
        public Adres IKAMETGAH1 { get => IKAMETGAH; set => IKAMETGAH = value; }

        public string ogr_bilgi_ver()
        {
            return "öğrenci adı " + " " + AD1 + " " + "ÖĞRENCİ SOYADI" + " " + SOYAD1 + " " + "ÖĞRENCİ NO" + " " + OGR_NO1 + " "
                + "ÖĞRENCİ MEMLEKET ADRESİ" + MEMLEKET1.Adres_bilgi_ver() + " " + "ÖĞRENCİ İKAMETGAH ADRESİ" + IKAMETGAH1.Adres_bilgi_ver();
        }
    }
}