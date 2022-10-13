using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanKayitSistemi
{
    public abstract class Calisan 
    {
        protected string ad;
        protected int yas;
        protected int kidem;
        protected int maas;

        public Calisan(string ad, int yas, int kidem, int maas)
        {
            this.ad = ad;
            this.yas = yas;
            this.maas = maas;
            this.kidem = kidem;
        }
        //public void setMaas(int maas)
        //{
        //    this.maas = maas;
        //}
        public int getMaas()
        {
            return maas;
        }
        //public void setKidem(int kidem)
        //{
        //    this.kidem = kidem;
        //}
        
        public int getKidem()
        {
            return kidem;
        }
        public virtual void kendiniTanit()
        {
            Console.Write("Ad={0},\tYaş={1},\tKıdem={2},\tMaaş={3},\t", ad, yas, kidem, maas);
        }
        public override string ToString()
        {
            return this.ad+ " " + this.yas + " " + this.maas + "xxxxxxxxxxxx";
        }
    }
}
