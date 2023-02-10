using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaccia_grafica
{
    public partial class Form1 : Form
    {
        public string[] vet;
        public int indice;

        public Form1()
        {
            InitializeComponent();
            vet = new string[100];
            indice = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //click bottone "Aggiunta"
        private void button1_Click(object sender, EventArgs e)
        {

            Aggiunta(vet, ref indice, textBox1.Text);
            listView1.Items.Add(textBox1.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {

           
            
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //funzioni servizio
        public void Aggiunta(string[] vet, ref int indice, string animale)
        {
            vet[indice] = animale;
            indice++;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
