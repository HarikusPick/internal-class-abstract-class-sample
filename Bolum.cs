using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalisanKayitSistemi
{
    internal class Bolum 
    {
        //private Calisan calisan1;  //assosiation
        public List<Calisan> calisanList; //aggregation
        private string bolumAdi;
        private string adres;
        private int kurulus;
        Array Calisan = new Array[5];
        private int toplamMaas;

        public Bolum(string bolumAdi, string adres, int kurulus, Array calisan, int toplamMaas) 
        {
            this.bolumAdi = bolumAdi;
            this.adres = adres;
            this.kurulus = kurulus;
            Calisan = calisan;
            this.toplamMaas = toplamMaas;
            calisanList = new List<Calisan>(1);
        }
        public void calisanEkle(Calisan c)
        {
            calisanList.Add(c);
        }

        public void printList()
        {
            if (calisanList == null) return;
            foreach (Calisan s in calisanList)
                Console.WriteLine(s);
            Console.WriteLine("xxxxxxxxxxxx");
        }
        public override string ToString()
        {
            string text = "bölümü = " + this.bolumAdi;
            foreach (Calisan s in calisanList)
                text += s;
            return text;
        }
    }
}
