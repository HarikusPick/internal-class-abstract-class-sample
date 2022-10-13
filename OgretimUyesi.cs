 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanKayitSistemi
{
    internal class OgretimUyesi : Calisan
    {
        private string unvan;

        public OgretimUyesi(string ad, int yas, int kidem, int maas) : base(ad, yas, kidem, maas)
        { 
        }
        //public void getUnvan()
        //{
            
        //}  
        public void setUnvan(string unvan)
        {
            this.unvan = unvan;
        }
        public override void  kendiniTanit()
        {
            base.kendiniTanit();
            Console.WriteLine("Ünvanı : " + unvan);
        }
    }
}
