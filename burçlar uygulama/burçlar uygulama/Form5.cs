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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ikizlerkadın a = new ikizlerkadın();
            a.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ikizlererkek a = new ikizlererkek();
            a.Show();
            this.Hide();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hava".ToString();
            textBox2.Text = "Değişken".ToString();
            textBox3.Text = "Merkür".ToString();
            textBox4.Text = "yeşil".ToString();
            textBox5.Text = "çarşamba".ToString();
            textBox6.Text = "5,7".ToString();
            textBox7.Text = "akik ,topak".ToString();
            textBox8.Text = "tüm cevapları bulabilmek".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal öncü, değişken ve sabit burçlar. İkizler burcu dört değişken burçtan biridir (diğerleri Başak, Yay ve Balık’tır). Değişken burçlar mevsimleri sona erdiren burçlardır ve her mevsimden dersler almışlardır. Her şeyin bir sonu olduğunu bilirler ve görevleri herkesin mevsim değişimine uyum sağlamasına yardımcı olmaktır. Diğer burçlardan daha bilgedirler. Diğer burçlara göre değişime daha kolay ayak uydurabilirler; pek çok duruma uyum sağlamak için bukalemun gibi renk değiştirirler. Ayrıca Zodyak’ın düzeltmenidirler: Kardinaller bir plan öne sürer, sabit burçlar planı eyleme döker, değişken burçlar ise eleştirel bir gözle son rötuşları yapar.Zodyak’ta hava elementine sahip olan ilk burç İkizler olduğu için İkizler burcu, değişim ve iletişim rüzgârlarını başlatan ilk rüzgâr gibidir. İkizler burcu, büyük ve yaratıcı bir sinerji oluşturarak bir anda insanları iletişime geçirir. İkizler burcu gezegen döngüsündeyken hepimiz arkadaşlarımızla daha fazla zaman geçirmeye meyilli oluruz.Enerjisi hızlı ve telaşlıdır. İkizler burcu iletişimi yönetir; esprili kelime oyunlarına, dinamik diyaloglara ilham verir. İkizler burcu geçişleri beyin fırtınaları ve sosyalleşme açısından harika bir dönemdir. Ayrıca bu burç, fikirlerin buluşmasından yanadır. İkizler burcu gezegen geçişi sırasında konuşma yetilerimiz gelişir; arkadaşlarımızla saatler boyunca o konudan bu konuya konuşurken bulabiliriz kendimizi. Öte yandan hayatın inişli çıkışlı yönünü temsil eder; ayak uydurmayı becerebilirseniz müthiş bir heyecan yaşamış olursunuz.İkizlerin doğası çocuk masumiyetine sahiptir; kardeşliğe, birbirinden tamamen farklı kişiliklere sahip olan dostlar ve akrabalar arası sevgiye olan inançlarını temsil eder. Bu burcun insanlarının görevi farklılıkları birleştirmek ve canlarını kardeşleri ya da arkadaşları uğruna feda etmeye hazır hâle getirmektir.Etkileyici ve zeki İkizler burcu, tek bir beden içinde iki farklı kişiliği temsil eder; hangisiyle karşı karşıya olacağınızı asla bilemezsiniz. Sosyal, dışa dönük ve eğlenceli olsalar da aniden ciddileşme ve huysuzlaşma eğilimindedirler. Son derece meraklıdırlar; her zaman yapmak istedikleri şeyler için yeterince vakitleri olmadığını düşünürler.".ToString();
                







        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
