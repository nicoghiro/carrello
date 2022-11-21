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

        public carrello(string id1, prodotto[] arrayp)
        {
            id = id1;
            prodotti = arrayp;
        }

        public string getId()
        {
            return id;
        }

        public void aggiungi(prodotto p)
        {
            prodotti[numeroprodotti] = p;
            numeroprodotti++;
        }

        public prodotto rimuovi(prodotto p)
        {
            for (int i = 0; i < numeroprodotti; i++)
            {
                if (p == prodotti[i])
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

        public prodotto[] getProdotti()
        {
            return prodotti;
        }
    }
}
