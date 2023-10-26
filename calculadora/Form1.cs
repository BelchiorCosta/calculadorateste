using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = a + b;
                label4.Text = c.ToString();
                listBox1.Items.Add(c.ToString());
            }
            catch {
                MessageBox.Show("Digite corretamente os numeros!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int posicao = listBox1.SelectedIndex;
            if (posicao < 0)
            {
                MessageBox.Show("Tem que selecionar um item!");
                return;
            }
            //criar um while porque enquanto os items escolhidos forem maiores que 0, irá remover
            while (listBox1.SelectedIndices.Count > 0)
            {
                //linha para remover os items escolhidos
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[0]);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = a - b;
                label4.Text = c.ToString();
                listBox1.Items.Add(c.ToString());
            }
            catch
            {
                MessageBox.Show("Digite corretamente os numeros!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = a / b;
                label4.Text = c.ToString();
                listBox1.Items.Add(c.ToString());
            }
            catch
            {
                MessageBox.Show("Digite corretamente os numeros!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = a * b;
                label4.Text = c.ToString();
                listBox1.Items.Add(c.ToString());
            }
            catch
            {
                MessageBox.Show("Digite corretamente os numeros!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}
