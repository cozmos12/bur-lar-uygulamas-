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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hava".ToString();
            textBox2.Text = "Sabit".ToString();
            textBox3.Text = "uranüs(özgürlük gezegeni)".ToString();
            textBox4.Text = "Turuncu".ToString();
            textBox5.Text = "Pazar".ToString();
            textBox6.Text = "4,7".ToString();
            textBox7.Text = "Yeşim ,obidiyen".ToString();
            textBox8.Text = "Özgür olamk".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Kova burcu dört sabit burçtan biridir; diğer dört sabit burç ise Boğa, Aslan ve Akrep’tir. Bu burçlar her mevsimin ortasına denk gelir. Bunlar dengeleyici burçlardır; kendilerine bir amaç belirler ve sonra da inşa etmeye başlarlar. Öncü burçların öne attığı heyecanlı fikirleri alır, bunları somut bir şeye dönüştürürler.Zodyak’ta hava grubuna ait üçüncü burç olan Kova burcu tıpkı diğer hava grubu burçları İkizler ve Terazi gibi oldukça zihinseldirler. Eğer zihinsel uyarım yoksa sıkılırlar ve motivasyonları düşer. Kova burcu üçüncü hava burcu olduğu için İkizler’in neşe rüzgarları ile Terazi’nin sevgi kelebeği havasını herkes için insancıl bir havaya dönüştürür.Kovalar utangaç ve sessiz, diğer yandan eksantrik ve enerjik olabilirler. Ancak her durumda başkalarına yardım etmeyi severler ve olayları önyargısız bir biçimde değerlendirebilirler. Bu durum onları problemleri kolaylıkla çözebilen insanlar yapar. Kova burcu insanları kendilerini çevreleyen enerjiye ve kalabalıklara kolayca uyum sağlayabilmelerine rağmen ender olarak yalnız kalma ihtiyacı da hisseder. Kovalar dünyaya olasılıklarla dolu bir yer olarak bakar.Kova burcu vizyonerliğini yönetici gezegeni Uranüs’ten alır. Yine Uranüs etkisiyle zaman zaman ürkek veya saldırgan olabilirler. Geleceği öngörebilir ve bundan beş yıl sonra ne yapmak istediklerini bilirler. Uranüs ayrıca onlara hızlı ve kolay dönüşüm becerisi de vermiştir. Bu sebeple “düşünür, ilerici ve hümanist” olarak bilinirler. Kova burcundaki insanlar topluluk içinde kendilerini iyi hisseder. Bu sayede çeşitli zihinsel çatışmalara girebilir, yeni şeylerden haberdar olabilirler. Kova burçları için en büyük zorluk kısıtlanma fikridir. Yalnız kendisi için değil herkes için özgürlük ve eşitlik isterler. Kovalar zaman zaman soğuk ve duyarsız olarak algılansalar da bu aslında haddinden önce başlayan yakınlıklara karşı bir savunma mekanizmasıdır. Başkalarına güvenmeyi ve duygularını samimi bir şekilde ifade etmeyi öğrenmelidirler.Kova enerjisi yenilikçi ve öncüdür. Deneysel elektronik müzikten toplum odaklı yaşamaya kadar bu burcun keşfetmeyeceği hiçbir şey yoktur. Grupları ve takımları yöneten bir burç olarak insanları toplumsal bir mesele ya da politik bir ajanda etrafında bir araya getirmek Kova burcunun özel ilgi alanıdır. Kova enerjisi keskin ve hatta bazen tuhaf bir enerjidir. Ütopik dünyalar hayal etmemizi sağlar; bilim kurgunun ve icatların burcudur. Kova etkisi bir yandan bizi asileştirebilir ve gerçeklikten uzaklaştırabilirken diğer yandan da başka zamanlarda göremediğimiz olasılıkları görmemize yardımcı olur. Ayrıca duygularımızı ifade etme konusunda gönülsüz olabiliriz – Kova enerjisi rasyonel akıl yürütmeyi ve duygulara soğukkanlı bir yaklaşımı tercih eder.".ToString();











        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            kovakadın a = new kovakadın();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kovaerkek a = new kovaerkek();
            a.Show();
            this.Hide();
        }
    }
}
