using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Kardeşler_Pide_Fırını_Online_Sipariş_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int topFiyat = 0;
        int adetKasar = 0;
        int adetKiyma = 0;
        int adetTavuk = 0;
        int adetKavurma = 0;
        int adetSosis = 0;
        int adetDomates = 0;
        int adetSucuk = 0;
        int adetKusbasi= 0;
        int adetMisir = 0;
        int adetAyran = 0;
        int adetKola= 0;
        int adetSariKola = 0;
        int adetSogukCay = 0;
        int adetMeyvaSuyu = 0;
        int adetBaklava = 0;
        int adetDondurma = 0;
        int adetPismaniye = 0;
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                adetKasar += 1;
            }
            if (checkBox2.Checked)
            {
                adetKiyma += 1;
            }
            if (checkBox3.Checked)
            {
                adetKavurma += 1;
            }
            if (checkBox7.Checked)
            {
                adetTavuk += 1;
            }
            if (checkBox5.Checked)
            {
                adetSosis += 1;
            }
            if (checkBox8.Checked)
            {
                adetDomates += 1;
            }
            if (checkBox4.Checked)
            {
                adetSucuk += 1;
            }
            if (checkBox6.Checked)
            {
                adetKusbasi += 1;
            }
            if (checkBox9.Checked)
            {
                adetMisir += 1;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                label6.Text = "Küçük";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label6.Text = "Orta";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label6.Text = "Orta";
            }




        }
    }
}
