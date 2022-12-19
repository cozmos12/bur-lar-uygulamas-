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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ateş".ToString();
            textBox2.Text = "Değişken".ToString();
            textBox3.Text = "jüpiter(şans gezegeni)".ToString();
            textBox4.Text = "Mavi".ToString();
            textBox5.Text = "Perşembe".ToString();
            textBox6.Text = "3,7".ToString();
            textBox7.Text = "safir lapis".ToString();
            textBox8.Text = "Kural koymak".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Yay burcu dört değişken burçtan biridir (diğerleri İkizler, Başak ve Balık’tır). Değişken burçlar mevsimleri sona erdiren burçlardır ve her mevsimden dersler almışlardır. Her şeyin bir sonu olduğunu bilirler ve görevleri herkesi mevsim değişimine uyum sağlamalarına yardımcı olmaktır. Diğer burçlardan daha bilgedirler. Diğer burçlara göre değişime daha kolay ayak uydurabilirler; pek çok duruma uyum sağlamak için bukalemun gibi renk değiştirirler. Ayrıca Zodyak’ın düzeltmenidirler: Kardinaller bir plan öne sürer, sabitler planı eyleme döker, değişkenler ise eleştirel bir gözle son rötuşları yapar.Yay burcu, ateş elementiyle yönetilen üç burçtan biridir (diğer iki ateş burcu Koç ve Aslan’dır). Yay burcu üçüncü ve sonuncu ateş burcu olduğu için Koç ve Aslan burcunun yarattığı liderlik ateşini dizginleyerek evrensel bir bilgi ve eylem süpernovasına dönüştürür. Zodyak’ın en ilham verici ve iyimser burcu olan Yay burcu bizi meselelerin üstesinden gelmeye ve sınırsız olasılıkların peşinden gitmeye zorlar. Yay burcu gezegen geçişi sırasında seyahat etmeye, öğrenmeye, kültürler arası bağlantı kurup ufkumuzu genişletmeye istekli olabiliriz. Diğer ateş burçları gibi Yay burcunun da sürekli olarak dünyayla temas halinde olması gereklidir.Yay burcunun yönetici gezegeni, güneş sistemimizin en büyük gezegeni Jüpiter’dir. Bu nedenle bu burcun insanları “hayatın kendisinden daha büyük” olabilirler. Nasıl ki Jüpiter gezegenler arasında gaz devlerinden biriyse, kendinden çok emin olan Yay enerjisi de zaman zaman hava gazıyla dolu görünebilir. Bir şey hakkında düşünmeden üzerine atlamak Yay burcunun âdetlerinden biridir. Neyse ki Jüpiter şans getirir ve ayaklarımızı yere sağlam basmamızı sağlar. Yay insanları her şeyin en büyüğünü ve en iyisini isterler; öyle ki zaman zaman aşırıya kaçabilirler. Sınırsız hedonizm ve rahatına düşkünlük, Yay enerjisini kötü bir enerjiye dönüştürebilir.Yay enerjisi kendisini aydınlanma, yolculuk ve doğruluk aracılığıyla gösterir. Meraklı Yay burcu bizi büyüme ve öğrenmeye aç hale getirir, hayatın anlamını bulmamıza yardımcı olacak maceralara sürükler. Felsefi yanı güçlü olan Yay burcu harikulade tartışmalara ilham verir, hayatı derinleştirir. Durmak nedir bilmeyen Yay burcu insanları dış mekân aktivitelerini sever; bu nedenle Yay burcu etkisi altındayken kendinizi yıldızların altında kamp yaparken ya da yeni bir şehri keşfederken bulabilirsiniz. Yay burcunun coşkulu yanı risk almamıza yardımcı olurken altından kalkamayacağımız işlere bulaşmamıza da sebep olabilir; bu nedenle bu burcun etkisi altındayken sınırlarımızı bilmemiz gerekir. Yoksa büyük bir heyecanla yeni projelere başlayıp yarım bırakabiliriz.".ToString();








        }

        private void button1_Click(object sender, EventArgs e)
        {
            yaykadın a = new yaykadın();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yayerkek a = new yayerkek();
            a.Show();
            this.Hide();
        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }
    }
}
