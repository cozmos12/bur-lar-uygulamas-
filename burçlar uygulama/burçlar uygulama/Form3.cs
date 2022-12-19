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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ateş".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: Kardinal (öncü), değişken ve sabit burçlar. Koç burcu dört kardinal burçtan biridir. Bu burçlar mevsimleri başlatır. Koç, baharı; Yengeç, yazı; Terazi, sonbaharı; Oğlak ise kışı başlatır. Bu burçlar özgün olmayı severler ve yaptıkları her şeyde birinci olmayı isterler. Akım belirleyicidirler; arkadaş ortamlarında partileri, organizasyonları onlar başlatan onlardır.Zodyak’ın ilk burcu olan Koç burcunun varlığı her zaman enerjik ve çalkantılı bir başlangıca işaret eder. Koç burçları çalışma ortamlarında da arkadaş ortamlarında da her zaman hareket, hız ve rekabet peşindedir; her şeyde birinci olmaya çalışırlar. Yönetici gezegenleri Mars’ın ateş elementine ait olması nedeniyle Koç burcu en aktif burçlardan biridir. Zaman zaman düşünmeden de olsa harekete geçmek onların doğasındadır.Güneş, Koç burcuna olağanüstü organizasyon becerileri verir: Öğlen arasından önce tek seferde birden fazla işi bitirmeyi beceremeyen bir Koç burcuyla karşılaşma ihtimaliniz düşüktür. Amaçları için mücadele etmeyi görev edinir, birlikteliğe ve takım çalışmasına önem verirler.Koç burcu insan vücudunda başı yönetir ve başla birlikte harekete geçer. Kelimenin tam anlamıyla başları dik yürürler. Doğal olarak cesurdurlar ve bir şeyi denemekten ya da risk almaktan nadiren korkarlar. Hangi yaşta olursalar olsunlar bir gencin gücüne ve enerjisine sahip olurlar; verilen herhangi bir görevi çabucak yerine getirirler.".ToString();
            textBox2.Text = "Kardinal".ToString();
            textBox3.Text = "Mars(savaş gezegeni)".ToString();
            textBox4.Text = "KIrmızı".ToString();
            textBox5.Text = "Salı".ToString();
            textBox6.Text = "1,9".ToString();
            textBox7.Text = "Opla,Yakut".ToString();
            textBox8.Text = "Bir numara olmak".ToString();















        }

        private void button1_Click(object sender, EventArgs e)
        {
            koç_kadın a = new koç_kadın();
            a.Show();
            this.Hide();
            button1.BackColor = Color.Red;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            koç_erkek a = new koç_erkek();
            a.Show();
            this.Hide();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();



        }
    }
}

