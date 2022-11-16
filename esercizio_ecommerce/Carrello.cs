using System;
using System.Collections.Generic;
using System.Text;

namespace esercizio_ecommerce
{
    class Carrello
    {
        string _id;


        public Carrello(string id)
        {
            _id = id;
        }

        public void Aggiungi(Prodotto p)
        {

        }
        public void Rimuovi(Prodotto p)
        {

        }
        public Prodotto [] Svuota()
        {
          Prodotto[] p = new Prodotto[10];

            return p;
        }

        public Prodotto[] getProdotto()
        {
            Prodotto[] p = new Prodotto[10];

            return p;

        }




    }
}
