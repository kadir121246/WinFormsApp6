using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            double a;
            string b = textBox1.Text.ToString();
            a = Convert.ToInt32(b);
            string kisi1, kisi2, kisi3, kisi4, kisi5, kisi6, kisi7;

            kisi1 = "1020";
            kisi2 = "1021";
            kisi3 = "1022";
            kisi4 = "1023";
            kisi5 = "1024";
            kisi6 = "999";


            // listBox2.Items.add(listBox1.SelectedItem.ToString());


            switch (a)
            {


                case 1020:

                    listBox1.Items.Add(b);
                    MessageBox.Show("kisi1");


                    break;
                case 1021:

                    listBox1.Items.Add(b);
                    MessageBox.Show("kisi2");

                    break;
                case 1022:

                    listBox1.Items.Add(b);
                    MessageBox.Show("kisi3");

                    break;
                case 1023:

                    listBox1.Items.Add(b);
                    MessageBox.Show("kisi4");

                    break;
                case 1024:

                    // listBox2.Items.Clear();
                    listBox1.Items.Add(b);
                    MessageBox.Show("kisi5");

                    break;



            }
            if (a < 1000)
            {
                MessageBox.Show("VIP müþteri     kisi6");
                listBox2.Items.Clear();
                listBox2.Items.Add(a);
            }




        }



        private void button4_Click_2(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox4.Text) && !string.IsNullOrWhiteSpace(textBox2.Text))
            {
                double f;
                string d = textBox2.Text.ToString();
                f = Convert.ToInt32(d);
                double tutar, toplam;
                tutar = Convert.ToInt32(textBox4.Text);
                if (checkBox1.Checked == true || f < 1000)
                {
                    toplam = tutar - (tutar * 0.2);
                }
                else
                {
                    toplam = tutar;
                }
                MessageBox.Show(Convert.ToString(toplam));
            }

            else
            {
                MessageBox.Show("Lütfen deðer giriniz veya üye seçin");
                //  if (!string.IsNullOrWhiteSpace(textBox2.Text))
                {
                    //   MessageBox.Show("üye seç");
                }
                //  else
                {
                }


            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {

            if (listBox1.SelectedItem != null)
            {
                textBox2.Text = listBox1.SelectedItem.ToString();

            }
            else if (listBox2.SelectedItem != null)
            {
                textBox2.Text = listBox2.SelectedItem.ToString();

            }
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            string veri1 = textBox2.Text.Trim();
            string veri2 = textBox3.Text.Trim();


            listBox3.Items.Add(string.Format("{0,10} {1,10}", veri1, veri2));
            MessageBox.Show(string.Format("{0,10} {1,10}", veri1, veri2));

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }
    }
}

