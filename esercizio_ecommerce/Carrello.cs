using System;
using System.Collections.Generic;
using System.Text;

namespace esercizio_ecommerce
{
    class Carrello
    {
        string _id;
        public Prodotto[] p = new Prodotto[10];
        public int counter;
        public Carrello(string id)
        {
            _id = id;
        }

        public void Aggiungi(Prodotto n)
        {
            counter = counter + 1;
            p[counter+1] = n;
        }
        public void Rimuovi(Prodotto n)
        {
            for (int i=0; i<p.Length;i++)
            {
                if (p[i] == n)
                {
                    p[i] = null;
                }
            }
        }
        public Prodotto [] Svuota()
        {
            for (int i = 0; i < p.Length; i++)
            {
                p[i] = null;
            }
            return p;
        }

        public Prodotto[] getProdotti()
        {
            return p;

        }




    }
}
