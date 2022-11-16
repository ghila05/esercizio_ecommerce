using System;
using System.Collections.Generic;
using System.Text;

namespace esercizio_ecommerce
{
    class Prodotto
    {
        string _id;
        string _nome;
        float _prezzo;
        string _produttore;
        string _descrizione;

        public Prodotto(string id, string nome, float prezzo, string produttore, string descrizione)
        {
            _id = id;
            _nome = nome;
            _prezzo = prezzo;
            _produttore = produttore;
            _descrizione = descrizione;
        }

        private void setPrezzo(float prezzo)
        {
            _prezzo = prezzo;
        }

 



    }
}
