using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POLab5
{
    class Stos
    {
        

        private int indeks = 0;
        private int rozmiar;
        public int[] stos;

        public Stos(int n)
        {
            this.rozmiar = n;
            this.stos = new int[n];
        }

        public void push()
        {
            if (indeks < rozmiar)
            {
                Console.WriteLine("Podaj liczbe, ktora chcesz dodac na stos: ");
                indeks++;
                stos[indeks] = Convert.ToInt32(Console.Read());
            }
            else
            {
                Console.WriteLine("Stos jest pelny");
            }
        }

        public void pop()
        {
            if (indeks >= 1)
            {
                Console.WriteLine("Usuwam element ze stosu");
                stos[indeks] = 0;
                indeks--;
            }
            else
            {
                Console.WriteLine("Stos jest pusty");
            }
        }

        public void wyswietlStos()
        {
            Console.WriteLine("Stos: ");
            for (int i = indeks; i >= 1; i--)
            {
                Console.WriteLine(stos[i]);
            }
        }
    }
}
