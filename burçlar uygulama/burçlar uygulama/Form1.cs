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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = Color.Red;
            Form3 a = new Form3();
            a.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Form2 a = new Form2();
            a.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.BackColor = Color.Red;
            Form6 a = new Form6();
            a.Show();
            this.Hide();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.Red;
            Form4 a = new Form4();
            a.Show();
            this.Hide();



        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.Red;
            Form5 a = new Form5();
            a.Show();
            this.Hide();





        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.BackColor = Color.Red;

            Form7 a = new Form7();
            a.Show();
            this.Hide();


        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.BackColor = Color.Red;
            Form8 a = new Form8();
            a.Show();
            this.Hide();





        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.BackColor = Color.Red;

            Form9 a = new Form9();
            a.Show();
            this.Hide();




        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.BackColor = Color.Red;


            Form10 a = new Form10();
            a.Show();
            this.Hide();





        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.BackColor = Color.Red;


            Form11 a = new Form11();
            a.Show();
            this.Hide();




        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.BackColor = Color.Red;

            Form12 a = new Form12();
            a.Show();
            this.Hide();




        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.BackColor = Color.Red;

            Form13 a = new Form13();
            a.Show();
            this.Hide();



        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.BackColor = Color.Red;

            Form14 a = new Form14();
            a.Show();
            this.Hide();



        }
    }
}
