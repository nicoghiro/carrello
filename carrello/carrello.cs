using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrello
{
    public class carrello
    {
        private string id; //primary key
        private int numeroprodotti = 0;
        private prodotto[] prodotti;
        float totale;
        public float Totale
        {
            get
            {
                return totale;
            }
            set
            {
                totale = value;
            }
        }
        public string ID
        {
            get
            {
                return id;
            }

            private set
            {
                id = value;
            }
        }
        public prodotto[] Prodotti
        {
            get 
            { 
                return prodotti;
            }
            private set
            {
                prodotti = value;
            }
        }

        public carrello(string id1, prodotto[] arrayp)
        {
            ID= id1;
            Prodotti = arrayp;
        }
        public carrello(string id1)
        {
            ID = id1;
           
        }


       
        public void aggiungi(prodotto p)
        {
            prodotti[numeroprodotti] = p;
            numeroprodotti++;
            Totale = Totale + p.Prezzo;
        }

        public prodotto  rimuovi(prodotto p)
        {
            for (int i = 0; i < numeroprodotti; i++)
            {
                if (p.ID == prodotti[i].ID)
                {
                    prodotti[i] = null;
                    return p;
                }
            }
            throw new Exception("prodotto insesistente");
        }

        public prodotto[] svuota()
        {
            prodotto[] array = new prodotto[999];
            for (int i = 0; i < numeroprodotti; i++)
            {
                array[i] = prodotti[i];
                prodotti[i] = null;
            }
            return array;
        }

     
    }
}
