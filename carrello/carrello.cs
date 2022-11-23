using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrello
{
    public class carrello
    {
        private string id; //primary key
        private int numeroprodotti ;
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
            numeroprodotti = 0;
            totale = 0;
        }
        public carrello(string id1)
        {
            ID = id1;
            Prodotti = new prodotto[100];
            numeroprodotti = 0;
            totale=0;
        }


       
        public void aggiungi(prodotto p)
        {
            if (p != null) { 
            
            prodotti[numeroprodotti] = p;
            numeroprodotti += 1;
            Totale = Totale + p.Prezzo;
            }
        }

        public prodotto  rimuovi(prodotto p)
        {
            for (int j = 0; j < numeroprodotti; j++)
            {
                if (prodotti[j]!=null && p.ID == prodotti[j].ID)
                {
                    
                    int index = j;

                    for (int i = index; i < prodotti.Length - 1; i++)
                    {
                        prodotti[i] = prodotti[i + 1];
                    }
                    Array.Resize(ref prodotti, prodotti.Length - 1);
                    numeroprodotti--;
                    totale-=p.Prezzo;
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
                totale = 0;
            }
            return array;
        }

     
    }
}
