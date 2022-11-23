﻿using System;
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
            for (int i = 0; i < numeroprodotti; i++)
            {
                if (prodotti[i]!=null && p.ID == prodotti[i].ID)
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
