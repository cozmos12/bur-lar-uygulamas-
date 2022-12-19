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
    public partial class terazikadın : Form
    {
        public terazikadın()
        {
            InitializeComponent();
        }

        private void terazikadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Terazi burcu kadınının her zaman bir ilişkisi vardır: ya uzun süreli bir ilişki içindedir ya da sürekli sevgili değiştirir. Bu aşk kadınları hiçbir zaman durulmayabilirler ama uzun süreli bir ilişki yaşadıklarında da asla geleneksel bir evlilik yapmazlar. Bazı Terazi kadınları “mükemmel sevgili” fantezisine kendilerini fazla kaptırırlar ve bu nedenle çok sık hayal kırıklığına uğrarlar. Öte yandan sevgilisini her yönüyle kabul edebildiği zaman güzel bir ilişki yaşayabilirler. Bu, sevgilisinin her şeyini sevmek demek değildir; daha ziyade kusurlu olmasına izin vermek demektir.".ToString();
            textBox2.Text= "Dizginlenmekten hoşlanmayan Terazi burcu kadınları için en uygun eş açık fikirli, kıskanç olmayan insanlardır. Ne isterse yapabileceğini bildiği bir ilişkide olduğu müddetçe ilişkilerine sadık kalırlar – bilhassa alelade flörtler, arkadaşça takılmalar gibi şeyler için açık kapı varsa.Aynı zamanda Terazi burcu kadınlarının, birlikte oldukları insanlara gerçek kişiliklerini göstermeye ihtiyacı vardır. Çünkü her şeyi toz pembe göstermek için acılarını saklama eğilimleri olabilir.".ToString();
            textBox3.Text = "Terazi burcu kadınları kendileri olmayı severler. Her zaman heyecanlı ve eğlenceli bir maceraya açıktırlar. Otostop çekmek, lunaparka gitmek gibi şeylere bayılırlar. Eğlenceye, gülmeye, neşeye ve güzelliğe düşkündürler. Özgür olmayı sevdikleri için olumsuz özellikleri fazla olan insanlardan kaçarlar. Tasasız, çekici ve rahattırlar.".ToString();
            textBox4.Text = "Terazi burcu kadınları alımlı dış görünüşlerine vurgu yapan hediyeleri çok beğenirler. Pek çok Terazi kadını süslenmeye bayılır. Bu nedenle güzel bir cep aynası harika bir hediye olabilir. Ayrıca romantik insanlar oldukları için gerçek çiçekler ya da kendi yazdığınız bir şiir de güzel bir seçenek.".ToString();












        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
