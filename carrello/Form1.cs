using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace carrello
{
    public partial class Form1 : Form
    { 
        prodotto[] disponibili = new prodotto[30];
       
       
       
        carrello carr = new carrello("12");
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            disponibili[0]=new prodotto(1, "mela", "ppppp", "verde", 25);
            disponibili[1] = new prodotto(2, "pera", "ppppp", "verde", 25);
           for(int i=0; i < 2; i++)
            {
                listView1.Items.Add(disponibili[i].ToString());
                
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indici=listView1.SelectedIndices.Count;
            carr.aggiungi(disponibili[indici]);
            MessageBox.Show(Convert.ToString(carr.Totale));
        }
    }
}
