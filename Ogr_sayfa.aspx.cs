using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.VisualBasic;

namespace Ogrenci_kayıt_otomasyon
{
    public partial class Ogr_sayfa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int adet = Convert.ToInt32(Interaction.InputBox("öğrenci sayısını giriniz:"));
            Ogrenci[] ogrenciler = new Ogrenci[adet];
            int sayac = 0;
            for (int i = 0; i < ogrenciler.Length; i++)
            {
                bool kontrol = false;
                int ogr_no = Convert.ToInt32(Interaction.InputBox("öğrenci no girin"));
                foreach (Ogrenci gel_ogr in ogrenciler)
                {
                    if (gel_ogr != null)
                    {
                        if (ogr_no == gel_ogr.OGR_NO1)
                        {
                            kontrol = true;
                            break;
                        }//dizi içinde kontrol yapıcaz
                    }
                }//foreach
                if (kontrol == true)
                {
                    i--;
                    Interaction.MsgBox("bu numarada öğrenci zaten kayıtlı lütfen başka bir öğrenci numarası giriniz");
                    continue;//eğer numara önceden varsa o numarayı almadan ve sonrasında yeni nesne oluşturmadan döngüde başa dönecek döngüde başa dönünce i+1 den sayacağı için dizide atlayark yazar elemanları bunu önlemek için varsa i yi bir azaktık başa döndüğünde i-1 dir i, 1 ekleyecek ya i-1+1 =i olacak yani i den başlamış olacak.
                }
                Ogrenci ogrencim = new Ogrenci()
                {
                    AD1 = Interaction.InputBox("öğrenci adı giriniz:"),
                    SOYAD1 = Interaction.InputBox("öğrenci soyadı giriniz:"),
                    OGR_NO1=ogr_no
                };
                Adres memleket = new Adres()
                {
                    IL1 = Interaction.InputBox("öğrenci memleket ilini giriniz:"),
                    ILCE1 = Interaction.InputBox("öğrenci memleket ilçesini giriniz:"),
                    MAHALLE1 = Interaction.InputBox("öğrenci memleket mahallesini giriniz:"),
                    APT_NO1 = Convert.ToInt32(Interaction.InputBox("öğrencinin memleket apt no giriniz:"))
                };
                Adres ikametgah = new Adres()
                {
                    IL1 = Interaction.InputBox("öğrenci ikametgah ilini giriniz:"),
                    ILCE1 = Interaction.InputBox("öğrenci ikametgah ilçesini giriniz:"),
                    MAHALLE1 = Interaction.InputBox("öğrenci ikametgah mahallesini giriniz:"),
                    APT_NO1 = Convert.ToInt32(Interaction.InputBox("öğrencinin ikametgah apt no giriniz:"))
                };
                ogrencim.MEMLEKET1= memleket;
                ogrencim.IKAMETGAH1 = ikametgah;
                sayac++;
                ogrenciler[i]= ogrencim;
                int cev = Convert.ToInt32(Interaction.MsgBox("devam etmek istiyor musunuz", MsgBoxStyle.YesNo));
                if (cev == 7) break;
            }//for
            Array.Resize(ref ogrenciler, sayac);
            foreach(Ogrenci ogr_lidt in ogrenciler)
            {
                ListBox1.Items.Add(ogr_lidt.ogr_bilgi_ver());
            }
        }
    }
}