using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2
{
    public partial class Form1 : Form
    {
        double wynik;
        double wzrost;
        double liczba=100;
        double waga;
        double wspK = 0.85;
        double wspM = 0.90;

        public Form1()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Convert.ToDouble(wzrost);
            wzrost = Convert.ToDouble(textBox1.Text);
            //label3.Text = Convert.ToString(wynik);
            //wynik = Convert.ToDouble(label3.Text);
            //double wzrost = Covert.ToDouble(TextWzrost);
            if((radioButton1.Checked == true) || (radioButton2.Checked == true))
            {
                if ((checkBox1.Checked == true) && (checkBox2.Checked == true))
                {
                    MessageBox.Show("Nie mozesz mieszac 2 opcji wag na raz !","uwaga");
                }
                else if ((radioButton1.Checked == true) && (checkBox1.Checked == true))
                {
                    waga = (wzrost - 100);
                    wynik = waga;
                    label3.Text = Convert.ToString(wynik);
                }
                else if ((radioButton1.Checked == true) && (checkBox2.Checked == true))
                {
                    waga = (wzrost - 100) * wspK;
                    wynik = waga;
                    label3.Text = Convert.ToString(wynik);
                }
                else if ((radioButton2.Checked == true) && (checkBox1.Checked == true))
                {
                    waga = (wzrost - 100);
                    wynik = waga;
                    label3.Text = Convert.ToString(wynik);
                }
                else if ((radioButton2.Checked == true) && (checkBox2.Checked == true))
                {
                    waga = (wzrost - 100) * wspM;
                    wynik = waga;
                    label3.Text = Convert.ToString(wynik);
                }
            }
            else
            {
                MessageBox.Show("Zaznacz poprawnie pierwsze dane !","uwaga");
            }

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
