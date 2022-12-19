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
    public partial class oğlakerkek : Form
    {
        public oğlakerkek()
        {
            InitializeComponent();
        }

        private void oğlakerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Oğlak erkekleri çoğu zaman acımasızlıkları ve zalimlikleri nedeniyle Zodyak’ın “kötü çocukları” olarak bilinirler. Öte yandan daha gençlik yıllarında kendi hayatlarını kurmaya başlarlar ve sorumluluk sahibi bir partner olurlar.".ToString();
            textBox2.Text = "Oğlak erkeğiyle birlikteyken onu sadece sabahleyin işe gitmeden önce ve akşam geç vakitte işten döndüğünde görme ihtimaliniz yüksek. Kendinize bir meşgale uydurduğunuz, bir işkolikle birlikte olmaktan sıkıntı duymadığınız müddetçe sorun çıkmayacaktır.".ToString();
            textBox3.Text = "Hedef odaklı Oğlak erkeğini, kariyer ile ilgili isteklerinden hiçbir şey alıkoyamaz. Her ne kadar aşırı ciddi görünseler de Oğlak erkeğini tanıdığınız zaman ne kadar hayat dolu olduğunu göreceksiniz. Oğlak erkekleri kara mizahı sever ve en iç karartıcı durumlarda gülünecek bir şey bulabilirlerse şayet içlerindeki melankolik eğilimi kontrol altına almayı başarabilirler.".ToString();
            textBox4.Text = "Oğlak erkeğine hediye almak zor olabilir çünkü israftan ve havailikten hiç hoşlanmaz. Yine de içten içe sevgi ve ilgi görmek için can atar. Oğlak erkekleri kaliteli şeylerden hoşlanır: Kaliteli deri eşyalar, ısmarlama giysiler, ceketler, antika eşyalar ya da nadir kitaplar hoşlarına gidecektir. En sevdiği yazara ait bir kitabın ilk baskısı güzel bir seçenek olabilir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 a = new Form12();
            a.Show();
            this.Hide();

        }
    }
}
