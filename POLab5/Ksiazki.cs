using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLab5
{
    class Ksiazki
    {
        private String tytul;
        private String autor;
        private int liczba_stron;
        private int rok_wydania;
        private double cena;

        public Ksiazki(String tytul, String autor, int liczba_stron, int rok_wydania, double cena)
        {
            this.tytul = tytul;
            this.autor = autor;
            this.liczba_stron = liczba_stron;
            this.rok_wydania = rok_wydania;
            this.cena = cena;
        }

        public String getTytul()
        {
            return tytul;
        }

        public String getAutor()
        {
            return autor;
        }

        public int getLiczba_stron()
        {
            return liczba_stron;
        }

        public int getRok_wydania()
        {
            return rok_wydania;
        }

        public double getCena()
        {
            return cena;
        }

        public void setCena(double cena)
        {
            this.cena = cena;
        }

        public String toString()
        {
            return "Tytl " + "ksiazki: " + tytul + ", autor: " + autor + ", liczba " + "stron: " + liczba_stron + ", rok " + "wydania: " + rok_wydania + ", cena: " + cena;
        }

    }
}
