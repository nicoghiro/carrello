using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrello
{
    public class prodotto
    {
        string id;
        string nome;
        string descrizione;
        string produttore;
        float prezzo;
        
        public prodotto(string Id ,string nomed,string prodottot,string descrittorer,float prezzor) { 
            ID = Id;
            Nome = nomed;
            Descrizione = descrittorer;
            Produttore = prodottot;
            Prezzo = prezzor;
            

           
            }
        public string ID
        {
            get { return id; }
            private set { id = value; }
        }
        public string Nome
        {
            get {
                return nome; 
            }
            private set { 
                nome = value;
            }
        }
        public string Descrizione
        {
            get {
                return descrizione;
            }
            private set
            {
                descrizione = value;
            }
        }
        public float Prezzo
        {
            get {
                return prezzo; 
            }
            private set
            {
                prezzo = value;
            }
        }
        public string Produttore
        {
            get { 
                return produttore;
            }
            private set
            {
                produttore = value;
            }
        }
        public string ToString()
        {
            return id.ToString()+" " + nome.ToString()+ " " + descrizione.ToString() + " "+ prezzo.ToString();
        }

    }
}
