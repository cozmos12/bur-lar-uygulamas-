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
    public partial class boğaerkek : Form
    {
        public boğaerkek()
        {
            InitializeComponent();
        }

        private void boğaerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Boğa erkeği doğru kişi için güvenilir ve adanmış sevgililer olabilirler. Her ne kadar sessiz görünseler de kelimelerle araları iyidir; seçtikleri kelimeler üzerinde uzun uzun düşünmeyi severler. Düşünceli bireyler olan Boğa erkekleri ne hissettiklerinden ya da ne istediklerinden emin değilseler sessiz kalmayı tercih edebilirler. Dolayısıyla bir karşılık vermeleri için zorlamamakta fayda vardır. Duygusal değişiklikleri üzerinde kafa yormayı sevdikleri için zamana ihtiyaçları vardır.".ToString();
            textBox2.Text = "Eğer içlerindeki feminen yönlerine dokunmayı becerebilirseler kendi duygularına güvenmeyi de öğrenebilirler. Ne yazık ki zor duygusal kararlar almaya zorlandıklarında kendilerini dışa kapatırlar ve duygusuzlaşmaya başlarlar. Nihayet açılmaya başladıklarında, tüm duygularını ifade etmesine teşvik edin ve abartılı tepkiler vermekten kaçının. Kalbini kazanmayı başarırsanız uzun süreli bir ilişki yaşarsınız ve sevgisini gösterme biçimi de şaşırtıcı derecede içtendir.".ToString();
            textBox3.Text = "Evcimen bir insan olan Boğa erkeği sevdiği kişiyle koltuğa uzanıp mayışmayı sever. Geleneksel yemeklere düşkündür ve zaman zaman evdeyken yemeği abartabilir; yemek onun için rahatlatıcı bir sığınaktır. Bazen dağınık olabilen Boğa erkekleri çoğu zaman sakardır; yaşadığı ortamın mümkün mertebe minimalist olması işlerini kolaylaştıracaktır.".ToString();
            textBox4.Text = "Boğa erkeğine sevginizi sözlerle ya da hediyelerle değil yaptıklarınızla göstermek en iyi seçenek olsa da kaliteli giysiler de hoşlarına gidecektir. Kitap, enstrüman gibi hediyeler de Boğa erkeğine uygun hediyeler arasındadır. Ayrıca boğazına hitap eden hediyeler de epey hoşlarına gider: En sevdiği restoranda güzel bir akşam yemeğine çıkarmak harika bir hediye olacaktır.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
