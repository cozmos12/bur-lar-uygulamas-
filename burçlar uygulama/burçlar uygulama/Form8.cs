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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Toprak".ToString();
            textBox2.Text = "Değişken".ToString();
            textBox3.Text = "Merkür".ToString();
            textBox4.Text = "gri ,bej".ToString();
            textBox5.Text = "Çarşaba".ToString();
            textBox6.Text = "5,14".ToString();
            textBox7.Text = "japer,tumalin".ToString();
            textBox8.Text = "Kahraman olmak".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Başak burcu dört değişken burçtan biridir (diğerleri İkizler, Yay ve Balık’tır). Değişken burçlar mevsimleri sona erdiren burçlardır ve her mevsimden dersler almışlardır. Her şeyin bir sonu olduğunu bilirler ve görevleri herkesi mevsim değişimine uyum sağlamalarına yardımcı olmaktır. Diğer burçlardan daha bilgedirler. Diğer burçlara göre değişime daha kolay ayak uydurabilirler; pek çok duruma uyum sağlamak için bukalemun gibi renk değiştirirler. Ayrıca Zodyak’ın düzeltmenidirler: Kardinaller bir plan öne sürer, sabitler planı eyleme döker, değişkenler ise eleştirel bir gözle son rötuşları yapar.Başak burcu toprak elementiyle yönetilen üç burçtan biridir. Diğer toprak burçları ise Boğa ve Oğlaktır. Başak burcu Zodyak’taki ikinci toprak burcu olduğu için Boğa’nın işi bıraktığı yerden devralır ve hızlıca kusursuz inşa bir planı yaparak Boğa’nın attığı sağlam temeller üzerinde yükselir. Başak burcu gezegen döngüsü sırasında ayrıntılar içinde ilahi olanı çabucak tespit eder, santim santim eksiksiz bir plan hazırlar ve hedeflerimizi yerine getiririz. Başak enerjisi bizi yeni bir çalışma rutini denemeye ya da o güne kadar benimsediğimiz sistemi yenilemeye teşvik eder. Ayrıca insanları gelecek konusunda endişeli (hatta evhamlı) hale getirebilir. Başak burcu gezegen geçişleri sırasında “ya öyle olursa”lara takılıp kalabiliriz.Başak’ın Boğa ve Oğlak’ın arasında bir toprak burcu olması onu güçlü ama muhafazakâr bir kişi olmaya iter. Gündelik hayatında düzenli ve pratiktir. Hayatları alt üst olduğu zaman bile düzenli bir hayat sürdürürler, hedefleri ve hayallerine bağlı kalırlar. Telafi edilmesi mümkün olmayan bir ayrıntıyı kaçırdıklarından sürekli endişe ettikleri için ayrıntılar içinde kaybolabilir, aşırı eleştirel olabilir ve diğer insanların pek önemsemediği meselelere kafa yorabilirler.Başak burcu, verimlilik bilincine sahip olmamıza ve fiziksel gerçekliklerimizi kavramamıza yardımcı olur. Öte yandan bizi mükemmeliyetçiliğe sürükler: Başak burcu gezegen geçişi sırasında kendimizi en ince detaylarına kadar işlenmiş binlerce karar vermek isteyip de bir adım atamazken bulabiliriz. Başak burcu seçiciliğinin ve yüksek standartlarının faydalı yönleri olsa da ilişkilerimizi mahvedebilir de.Başakların insanlık bilinci yüksektir; bu da onları Zodyak’ın en duyarlı burçlarından biri kılar. Hayata olan sistemli yaklaşımları hiçbir şeyin şansa bırakılmamasını sağlar. Her ne kadar çoğunlukla şefkatli olsalar da kalpleri dış dünyaya kapalı olabilir. Başak burcu çoğu zaman yanlış anlaşılan bir burçtur; kendilerini ifade etme yeteneğinden yoksun oldukları için değil, duyguları akla aykırı olduğu zaman bu duyguları doğru kabul etmedikleri için.".ToString();










        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            başakkadını a = new başakkadını();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            başakerkek a = new başakerkek();
            a.Show();
            this.Hide();

        }
    }
}
