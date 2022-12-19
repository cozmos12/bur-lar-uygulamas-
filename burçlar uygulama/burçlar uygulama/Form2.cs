using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace burçlar_uygulama
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gün = Convert.ToInt32(comboBox1.Text);
            string ay = Convert.ToString(comboBox2.Text);

            if (gün >= 21 && ay == "MART" || gün <= 19 && ay == "NİSAN")
            {
                textBox1.Text = "KOÇ";






            }

            else if (gün >= 20 && ay == "NİSAN" || gün <= 20 && ay == "MAYIS")
            {

                textBox1.Text = "boğa";


            }        

            else if(gün>=21&&ay=="MAYIS"||gün<=20&&ay=="HAZİRAN")
            {

                textBox1.Text = "ikizler";


            }

           else if(gün>=21&&ay=="HAZİRAN"||gün<=22&&ay=="TEMMUZ")
            {


                textBox1.Text = "yengeç";



            }


            else if(gün>=23&&ay=="TEMMUZ"||gün<=22&&ay=="AĞUSTOS")



            {

                textBox1.Text = "aslan";



            }


            else if(gün>=23&&ay=="AĞUSTOS"||gün<=22&&ay=="EYLÜL")
            {


                textBox1.Text = "başak";



            }

            else if (gün>=23&&ay=="EYLÜL"||gün<=22&&ay=="EKİM")
            {

                textBox1.Text = "terazi";


            }


            else if(gün>=23&&ay=="KASIM"||gün<=22&&ay=="KASIM")
            {
                textBox1.Text = "akrep";



            }


            else if(gün>=22&&ay=="KASIM"||gün<=21&&ay=="ARALIK")
            {

                textBox1.Text = "yay";


            }

            else if(gün>=22&&ay=="ARALIK"||gün<=19&&ay=="OCAK")
            {

                textBox1.Text = "oğlak";


            }

            else if(gün>=20&&ay=="OCAK"||gün<=18&&ay=="ŞUBAT")
            {

                textBox1.Text = "kova";


            }


            else if(gün>=19&&ay=="ŞUBAT"||gün<=20&&ay=="MART")
            {
                textBox1.Text = "balık";




            }











        }

        private void button2_Click(object sender, EventArgs e)
        {

            int gün2 = Convert.ToInt32(comboBox3.Text);
            int gün = Convert.ToInt32(comboBox1.Text);
            string ay = Convert.ToString(comboBox2.Text);







            if (gün + gün2 <= 20 && ay == "MART" || gün + gün2 >= 19 && ay == "ŞUBAT")

            {

                textBox2.Text = "balık";


            }


            else if (gün + gün2 <= 19 && ay == "OCAK"||gün+gün2>= 22&&ay=="ARALIK")

            {


                textBox2.Text = "oğlak";
            }






            else if (gün + gün2 <= 18 && ay == "ŞUBAT" || gün + gün2 >= 20 && ay == "OCAK")

            {


                textBox2.Text = "kova";
            }





            else if (gün + gün2 <= 21 && ay == "ARALIK" || gün + gün2 >= 22 && ay == "KASIM")

            {


                textBox2.Text = "yay";
            }




            else if (gün + gün2 <= 21 && ay == "KASIM" || gün + gün2 >= 23 && ay == "EKİM")

            {


                textBox2.Text = "akrep";
            }


            else if (gün + gün2 <= 22 && ay == "EKİM" || gün + gün2 >= 23 && ay == "EYLÜL")

            {


                textBox2.Text = "terazi";
            }


            else if (gün + gün2 <= 22 && ay == "EYLÜL" || gün + gün2 >= 23 && ay == "AĞUSTOS")

            {


                textBox2.Text = "başak";
            }


            else if (gün + gün2 <= 22 && ay == "AĞUSTOS" || gün + gün2 >= 23 && ay == "TEMMUZ")

            {


                textBox2.Text = "aslan";
            }




            else if (gün + gün2 <= 22 && ay == "TEMMUZ" || gün + gün2 >= 21 && ay == "HAZİRAN")

            {


                textBox2.Text = "yengeç";
            }




            else if (gün + gün2 <= 20 && ay == "HAZİRAN" || gün + gün2 >= 21 && ay == "MAYIS")

            {


                textBox2.Text = "ikizler";
            }


            else if (gün + gün2 <= 20 && ay == "MAYIS" || gün + gün2 >= 20 && ay == "NİSAN")

            {


                textBox2.Text = "boğa";
            }



            else if (gün + gün2 <=19 && ay == "NİSAN" || gün + gün2 >= 21 && ay == "MART")

            {


                textBox2.Text = "koç";
            }








        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();


        }
    }
}
