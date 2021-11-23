using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_objekti
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            osoba.setIme("Pero");
            osoba.setGodinaRodjenja(1997);
            osoba.setVisina(182);
            osoba.setTezina(85);
            osoba.setPrezime("Perić");
            osoba.SetSpol('M');

            Console.WriteLine("Ime i prezime:" + osoba.getIme() +" " + osoba.getPrezime());
            Console.WriteLine("Godina rođenja:" + osoba.getGodinaRodjenja() + ".");
            Console.WriteLine("Visina:" + osoba.getVisina() + " cm");
            Console.WriteLine("Težina:" + osoba.getTezina() + " kg");
            Console.WriteLine("Spol:" + osoba.GetSpol());

            Osoba osoba1 = new Osoba("Ana", "Anić", 2003, 164, 'Ž', 62);

            Console.WriteLine(osoba1.ToString());
            
            
            Console.ReadKey();
        }
    }

    class Osoba
    {
        String ime, prezime;
        int godinaRodjenja, visina, tezina;
        char spol;

        public override string ToString()
        {
            string ispis = "Ime i prezime:" + this.getIme() + " " +this.getPrezime() + "\n"
                +"Godina rođenja:" + this.getGodinaRodjenja() +".\n"
                + "Visina:" + this.getVisina() + " cm\n"
                + "Težina:" + this.getTezina() + " kg\n"
                + "Spol:" + this.GetSpol();
            return ispis;
        }

        public Osoba()
        {

        }

        public Osoba(String ime, String prezime, int godinaRodjenja,int visina, char spol, int tezina)
        {
            this.ime=ime;
            this.prezime=prezime;
            this.godinaRodjenja=godinaRodjenja;
            this.visina=visina;
            this.spol=spol;
            this.tezina=tezina;
        }


        public char GetSpol()
        {
            return spol;
        }

        public void SetSpol(char value)
        {
            spol = value;
        }

        public void setIme (String ime)
        {
            this.ime = ime;
        }

        public void setGodinaRodjenja(int godinaRodjenja)
        {
            this.godinaRodjenja=godinaRodjenja; 
        }

        public void setPrezime(String prezime)
        {
            this.prezime = prezime;
        }

        public void setVisina(int visina)
        {
            this.visina = visina;   
        }

        public void setTezina(int tezina)
        {
            this.tezina = tezina;
        }

        public String getIme()
        {
            return this.ime;
        }

        public int getGodinaRodjenja()
        {
            return this.godinaRodjenja;
        }

        public String getPrezime()
        {
            return this.prezime;
        }

        public int getVisina()
        {
            return this.visina;
        }

        public int getTezina()
        {
            return this.tezina;
        }

    }
}
