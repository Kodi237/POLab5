using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLab5
{
    class Liczba
    {
        public int liczba;

        public Liczba(int liczba)
        {
            this.liczba = liczba;
        }

        public static int rozmiarTablicy(int liczba)
        {
            int licznik = 0;
            while (liczba / 10 != 0)
            {
                liczba = liczba / 10;
                licznik++;
            }
            return licznik;
        }

        int[] tab = new int[rozmiarTablicy(liczba)]; // Coś, coś, coś się popsuło

        void rozlozLiczbe(int liczba)
        {
            for (int i = 0; i < rozmiarTablicy(liczba); i++)
            {
                tab[i] = liczba % 10;
                liczba = liczba / 10;
            }
        }

        void wypiszLiczbe()
        {
            Console.WriteLine("podana liczba: " + this.liczba);
        }

        void podajLiczbe()
        {
            Console.WriteLine("Podaj liczbe: ");
            this.liczba = Convert.ToInt32(Console.Read());
        }

        int silnia(int n)
        {
            if (n <= 1)
                return 1;
            else
                return n * silnia(n - 1);
        }
    }
}
