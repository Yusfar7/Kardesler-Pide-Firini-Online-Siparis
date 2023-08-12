using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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

        public void button3_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                
            }
            if (checkBox2.Checked)
            {
                
            }
            if (checkBox3.Checked)
            {
                
            }
            if (checkBox7.Checked)
            {
                
            }
            if (checkBox5.Checked)
            {
                
            }
            if (checkBox8.Checked)
            {
                
            }
            if (checkBox4.Checked)
            {
                
            }
            if (checkBox6.Checked)
            {
                
            }
            if (checkBox9.Checked)
            {
                
            }
            listBox1.Items.Add(numericUpDown1.Value + " Adet " + comboBox1.Text + " Boy /");
            listBox1.Items.Add("Malzemeler:");
            if (checkBox1.Checked)
            {
                 listBox1.Items.Add("Kaşar");
                topFiyat += 20 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox2.Checked)
            {
                listBox1.Items.Add("Kıyma");
                topFiyat += 50 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox3.Checked)
            {
                listBox1.Items.Add("Kavurma");
                topFiyat += 65 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox4.Checked)
            {
                listBox1.Items.Add("Sucuk");
                topFiyat += 40 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox5.Checked)
            {
                listBox1.Items.Add("Sosis");
                topFiyat += 35 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox6.Checked)
            {
                listBox1.Items.Add("Kuşbaşı");
                topFiyat += 70 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox7.Checked)
            {
                listBox1.Items.Add("Tavuk");
                topFiyat += 35 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox8.Checked)
            {
                listBox1.Items.Add("Domates");
                topFiyat += 5 * Convert.ToInt32(numericUpDown1.Value);
            }
            if (checkBox9.Checked)
            {
                listBox1.Items.Add("Mısır");
                topFiyat += 5 * Convert.ToInt32(numericUpDown1.Value);
            }
            
            listBox1.Items.Add("----------------------------------");
            
            if (comboBox2.SelectedIndex == 0)
            {
                adetAyran += Convert.ToInt32(numericUpDown2.Value);
                topFiyat += 6 * Convert.ToInt32(numericUpDown2.Value);
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                adetKola += Convert.ToInt32(numericUpDown2.Value);
                topFiyat += 10 * Convert.ToInt32(numericUpDown2.Value);
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                adetSariKola += Convert.ToInt32(numericUpDown2.Value);
                topFiyat += 8 * Convert.ToInt32(numericUpDown2.Value);
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                adetSogukCay += Convert.ToInt32(numericUpDown2.Value);
                topFiyat += 7 * Convert.ToInt32(numericUpDown2.Value);
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                adetMeyvaSuyu += Convert.ToInt32(numericUpDown2.Value);
                topFiyat += 9 * Convert.ToInt32(numericUpDown2.Value);
            }
            if (comboBox3.SelectedIndex == 0)
            {
                adetBaklava += Convert.ToInt32(numericUpDown3.Value);
                topFiyat += 15 * Convert.ToInt32(numericUpDown3.Value);
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                adetDondurma += Convert.ToInt32(numericUpDown3.Value);
                topFiyat += 12 * Convert.ToInt32(numericUpDown3.Value);
            }
            if (comboBox3.SelectedIndex == 2)
            {
                adetPismaniye += Convert.ToInt32(numericUpDown3.Value);
                topFiyat += 20 * Convert.ToInt32(numericUpDown3.Value);
            }
            label16.Text = "Ayran: " + adetAyran + " Adet";
            label17.Text = "Kola: " + adetKola + " Adet";
            label18.Text = "Sarı Kola: " + adetSariKola + " Adet";
            label19.Text = "Soğuk Çay: " + adetSogukCay +" Adet";
            label20.Text = "Meyva Suyu: " + adetMeyvaSuyu+" Adet";
            label21.Text = "Baklava: " + adetBaklava + " Adet";
            label22.Text = "Dondurma: " + adetDondurma + " Adet";
            label23.Text = "Pişmaniye: " + adetPismaniye + " Adet";
            label24.Text = "Ödeme Türü: " + comboBox4.Text;
            label25.Text = "Tutar: " + Convert.ToInt32(topFiyat);
            textBox4.Text = "Ad: " + textBox1.Text;
            textBox3.Text = "Telefon: " + textBox2.Text;
            richTextBox2.Text = "Adres: " + richTextBox1.Text;

        }

        

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("Sipariş:");
            listBox1.Items.Add("--------------------------------------");
            topFiyat = 0;
            label25.Text = "Tutar: " + topFiyat;
            

            adetAyran = 0;
            adetKola = 0;
            adetSariKola = 0;
            adetSogukCay = 0;
            adetMeyvaSuyu = 0;
            adetBaklava = 0;
            adetDondurma = 0;
            adetPismaniye = 0;
            textBox1.Text = "Ad Soyad";
            textBox2.Text = "Telefon";
            richTextBox1.Text = "Adres";
            richTextBox2.Text = "Adres: ";
            textBox3.Text = "Telefon: ";
            textBox4.Text = "Ad Soyad: ";
            comboBox4.SelectedIndex = 3;
            label16.Text = "Ayran: " + adetAyran + " Adet";
            label17.Text = "Kola: " + adetKola + " Adet";
            label18.Text = "Sarı Kola: " + adetSariKola + " Adet";
            label19.Text = "Soğuk Çay: " + adetSogukCay + " Adet";
            label20.Text = "Meyva Suyu: " + adetMeyvaSuyu + " Adet";
            label21.Text = "Baklava: " + adetBaklava + " Adet";
            label22.Text = "Dondurma: " + adetDondurma + " Adet";
            label23.Text = "Pişmaniye: " + adetPismaniye + " Adet";
            label24.Text = "Ödeme Türü: " + comboBox4.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            checkBox6.Checked = false;
            checkBox7.Checked = false;
            checkBox7.Checked = false;
            checkBox8.Checked = false;
            checkBox9.Checked = false;
            comboBox1.SelectedIndex = 3;
            comboBox2.SelectedIndex = 5;
            comboBox3.SelectedIndex = 3;
            numericUpDown1.Value = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;


        }
    }
}
