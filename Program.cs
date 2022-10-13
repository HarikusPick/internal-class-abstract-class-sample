using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanKayitSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            OgretimUyesi ogretimUyesi1 = new OgretimUyesi("ahmet", 30, 5, 7800);
            ogretimUyesi1.setUnvan(" DR ");
            //ogretimUyesi1.
            OgretimUyesi ogretimUyesi2 = new OgretimUyesi("mehmet", 35, 10, 8800);
            ogretimUyesi2.setUnvan(" DOC.DR ");
            OgretimUyesi ogretimUyesi3 = new OgretimUyesi("ali", 28, 2, 6500);
            ogretimUyesi3.setUnvan(" OP.DR ");
            OgretimUyesi ogretimUyesi4 = new OgretimUyesi("veli", 43, 20, 11000);
            ogretimUyesi4.setUnvan(" PROF.DR ");
            string[] deneme = new string[4] {"","","",""};

            Bolum muhendislik = new Bolum("muhendislik", "adres1", 1869, deneme, 1835000 );

            muhendislik.printList();
            ogretimUyesi1.kendiniTanit();
            ogretimUyesi2.kendiniTanit();
            ogretimUyesi3.kendiniTanit();
            ogretimUyesi4.kendiniTanit();


            Console.ReadKey();
        }
    }
}
