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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Toprak".ToString();
            textBox2.Text = "Kardinal".ToString();
            textBox3.Text = "Satürn(disipilinin gezegeni)".ToString();
            textBox4.Text = "kahverengi".ToString();
            textBox5.Text = "Cumartesi".ToString();
            textBox6.Text = "4,8".ToString();
            textBox7.Text = "turmalin ,zirkon".ToString();
            textBox8.Text = "Her ihtiyacı karşılayabilmek".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Yengeç burcu dört kardinal burçtan biridir. Bu burçlar mevsimleri başlatır. Koç, baharı; Yengeç, yazı; Terazi, sonbaharı; Oğlak ise kışı başlatır. Bu burçlar özgün olmayı severler ve yaptıkları her şeyde birinci olmayı isterler. Akım belirleyicidirler; arkadaş ortamlarında partileri, organizasyonları onlar başlatır.Oğlak burcu toprak elementine bağlı üç Zodyak burcundan biridir (diğerleri Boğa ve Başak’tır). Oğlak burcu üçüncü ve sonuncu toprak burcu olduğu için, Boğa burcunun kaya gibi sağlam temelleriyle Başak burcunun hünerli planlarını büyük bir binaya dönüştürerek dünyaya hükmedeceği bir yer haline getirir. Oğlaklar Zodyak’ın usta stratejistleridir, her zaman bir beş-on yıllık planları vardır. Oğlak burcu gezegen döngüsünün etkisi altındayken en büyük hedeflerimizi gerçekleştirmeye ve hayatımızda uzun süreli yapılar inşa etmeye istekli hale geliriz.Oğlak burcu sadece maddi dünyaya odaklanmakla kalmaz, bu dünyayı kullanmayı da becerebilirler. Ne yazık ki toprak elementi onları aynı zamanda sert ve bazen de inatçı kılar; o kadar ki bir ilişkide başka bir perspektiften bakmayı beceremezler. Kendi kişiliklerinden çok farklı olan insanların farklılıklarını kabullenmekte zorlanır ve kendi geleneksel değerlerini dayatmaya çalışabilirler.Oğlak burcunun yönetici gezegeni acımasız ve otoriter Satürn’dür. Ayrıca Satürn psikolojik baskının gezegenidir; bu da Oğlak’ın yıkıcı tavırlarla çıkagelmesine sebep olabilir. Oğlak burcunun kaya gibi görüntüsünün altında korkunç sırlarla karşılaşırsanız şaşırmayın. Satürn’ün etkisi insanları pratik ve sorumluluk sahibi kişiler olmaya itse de diğer yandan da soğuk, mesafeli ve bağışlamaz insanlar olmalarına, suçluluk duygusu hissetmelerine ve geçmişe dönmelerine sebep olur.Oğlak enerjisi inatçı ve kararlıdır; yüce hedeflere adanmış bir enerjidir. Zihnimizi sonuca odaklamamıza ve bitiş çizgisine ulaşmamıza yardımcı olur. Bitiş çizgisine ulaşmak destansı bir yolculuk olabilir; bu nedenle Oğlak’ın çelik gibi sinirlerine ve mukavemetine ihtiyaç duyarız. Az kullanılan yollardan gitmek bu geleneksel burcun tercih edeceği bir şey değildir. Bunun yerine Oğlak burcu zirveye ulaşan en düz ve en basit yolun haritasını çıkarır ve sonra da planına sadık kalır. Oğlak enerjisi son derece sert ve çıkarcı olabilir; vazifeşinas tarafı çöküşüne yol açabilir.".ToString();













        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oğlakkadın a = new oğlakkadın();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            oğlakerkek a = new oğlakerkek();
            a.Show();
            this.Hide();
        }
    }
}
