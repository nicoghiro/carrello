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
        prodotto[] disponibili1 = new prodotto[30];
        int cont = 2;
        int cont1 = 0;

       
       
        carrello carr = new carrello("12");
        
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            disponibili[0]=new prodotto("1", "mela", "ppppp", "verde", 25);
            disponibili[1] = new prodotto("2", "pera", "ppppp", "verde", 25);
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
            if(string.IsNullOrEmpty(textBox1.Text)|| string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text) || string.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Inserire valori per tutti i parametri");
            }
            else
            {
                disponibili[cont] = new prodotto(textBox1.Text, textBox2.Text, textBox3.Text, textBox5.Text, Decimal.ToInt32(numericUpDown1.Value));
                listView1.Items.Add(disponibili[cont].ToString());
                cont++;
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            int indici = listView1.FocusedItem.Index;
            string p = Convert.ToString(indici);
            carr.aggiungi(disponibili[indici]);
            disponibili1[cont1] = disponibili[indici];
            listView2.Items.Add(disponibili1[cont1].ToString());
            cont1++;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int indici = listView2.FocusedItem.Index;
            string p = Convert.ToString(indici);
            carr.rimuovi(disponibili1[indici]);
            
            int index = indici;

            for (int i = index; i < disponibili1.Length - 1; i++)
            {
                disponibili1[i] = disponibili1[i + 1];
            }
            Array.Resize(ref disponibili1, disponibili1.Length - 1);
            listView2.Items.RemoveAt(indici);
            cont1--;
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("sei sicuro di voler svuotare il carrello?", "eliminazione", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                carr.svuota();
                listView2.Clear();
                cont1 = 0;
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
}
