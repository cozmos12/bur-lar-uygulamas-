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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Boğa burcu dört sabit burçtan biridir; diğer dört sabit burç ise Aslan, Akrep ve Kova’dır. Bu burçlar her mevsimin ortasına denk gelir. Bunlar dengeleyici burçlardır; kendilerine bir amaç belirler ve sonra da inşa etmeye başlarlar. Öncü burçların öne attığı heyecanlı fikirleri alır, bunları somut bir şeye dönüştürürler.Boğa burcu toprak elementi altında gruplanan üç burçtan biridir (diğerleri Başak ve Oğlak’tır). Zodyak döngüsündeki ilk toprak burcu olduğu için binayı oluşturan temel gibidir. Çoğu Boğa insanı dengeleyicidir, kendileri ve başkaları için güvenliği sağlamaya çalışırlar. Meseleleri ayakları yere basan, pratik ve gerçekçi bir bakış açısıyla görmeye meyillidirler. Boğa burcu için para kazanmak kolaydır ve yıllarca aynı proje üzerinde çalışabilirler.Hantal ve inatçı bir burç olan Boğa burcu enerjisinin iki farklı hızı vardır: Ya çayırda otlayan bir öküz gibi gevşemiş bir haldedir ya da boğa güreşindeki bir boğa gibi coşkulu. Boğa burcu içsel bir enerji tasarrufu programına sahiptir. Eğer bir şey zaman ve kaynak yatırımına değerse sabırlı bir şekilde ona ulaşır. Yaptığı işi küçük aşamalara bölmeyi sever.Her ne kadar inatçılıkları olumsuz yanları olsa da bu inatçılıkları bağlılık olarak da adlandırılabilir; her ne olursa olsun görevleri yerine getirme yetenekleri muazzamdır. Bu da onları harika çalışanlar yapan bir özelliktir. Ayrıca uzun süreli arkadaşlık ve sevgililik de Boğa burcunun özelliğidir.Boğa burcunun yönetici gezegeni aşkın, cazibenin, güzelliğin, tatminin, yaratıcılığın ve kadirşinaslığın gezegeni olan Venüs’tür. Boğa burçları sadıktır ve ani değişiklikleri, eleştirileri sevmezler. ".ToString();
            textBox1.Text = "Toprak".ToString();
            textBox2.Text = "Sabit".ToString();
            textBox3.Text = "Venüs".ToString();
            textBox4.Text = "yeşil ".ToString();
            textBox5.Text = "cuma".ToString();
            textBox6.Text = "6,4".ToString();
            textBox7.Text = "Turkuaz taşı, Topaz taşı, Pembe Kuvars, Safir, Yeşim".ToString();
            textBox8.Text = " Her şeyin en iyisine sahip olmak".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            boğakadın a = new boğakadın();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            boğaerkek a = new boğaerkek();
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
