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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hava".ToString();
            textBox2.Text = "Kardinal".ToString();
            textBox3.Text = "Venüs (güzelğin gezegeni)".ToString();
            textBox4.Text = "pembe ".ToString();
            textBox5.Text = "cuma".ToString();
            textBox6.Text = "4,6".ToString();
            textBox7.Text = "Cuma".ToString();
            textBox8.Text = "Sevmek ve sevilmek".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Terazi burcu dört kardinal burçtan biridir. Bu burçlar mevsimleri başlatır. Koç, baharı; Yengeç, yazı; Terazi, sonbaharı; Oğlak ise kışı başlatır. Bu burçlar özgün olmayı severler ve yaptıkları her şeyde birinci olmayı isterler. Akım belirleyicidirler; arkadaş ortamlarında partileri, organizasyonları onlar başlatır.Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Terazi burcu dört kardinal burçtan biridir. Bu burçlar mevsimleri başlatır. Koç, baharı; Yengeç, yazı; Terazi, sonbaharı; Oğlak ise kışı başlatır. Bu burçlar özgün olmayı severler ve yaptıkları her şeyde birinci olmayı isterler. Akım belirleyicidirler; arkadaş ortamlarında partileri, organizasyonları onlar başlatır.Adalet terazisi ile sembolize edilen Terazi burcu denge ve adalet timsalidir. Bu burcun etkisi, ne kadar büyük olursa olsun her türlü meselenin dengeye kavuşmasını sağlar. Büyük bir yasal ya da ahlâkî çatışmanın çözülmesinden tutun bir tablonun nereye asılması gerektiğini belirlemeye kadar, Terazi enerjisini kişiler arası ve estetik ahengi tesis etmeden alıkoyacak hiçbir şey yoktur. Terazi burcu gezegen geçişi sırasında ilişkilerimizde tekrardan zemin kazanır ve hayatlarımızda daha fazla denge arayışına gireriz. Terazi enerjisi toplumsal meziyetlerimizi güçlendirir ve dikkatimizi güzelliğe yönlendirir.Terazi burcu insanları barışçıl ve adildir. Yalnız kalmaktan nefret ederler. Yanlarında kendileri için bir ayna görevi görecek birilerinin olmasını isterler. Bu bireylerin en çok hoşuna giden şey denge ve simetridir; her daim adalet ve eşitlik peşindedirler. Öte yandan çatışmadan kaçmak için neredeyse her şeyi yapar, mümkün olan her yerde barışı sürdürmeye çalışırlar.".ToString();






















        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            terazikadın a = new terazikadın();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            terazierkek a = new terazierkek();
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
