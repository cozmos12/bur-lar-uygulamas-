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
    public partial class akrepkadın : Form
    {
        public akrepkadın()
        {
            InitializeComponent();
        }

        private void akrepkadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Daima sığınılacak bir liman olabilen Akrep kadını hayatının sonuna kadar güçlü olacak ve hayatın yükünü sizden fazla üstlenecektir. Akrep kadını geçici ilişkilerden çok sonsuz aşkın peşindedir. Aradığını bulduğu an uzun yıllar partnerine sadık kalır ve ona ihtiyaç duyduğu güveni verebilirseniz hiç kimseye asla açmadığı iç dünyasını bile sizinle paylaşacaktır".ToString();
            textBox2.Text = "Çoğu Akrep kadını aşkın hayatta bir kez karşısına çıkacağına inanır, o şanslı kişiyi bulduğunda her haliyle sever ve uzun yıllar boyunca kopamaz. Bu nedenle bazen Akrep kadınının hayatı tüm gerçekliğiyle kabullenme becerisi aşk konusunda başını ağrıtabilir. Yanlış ilişkilere saplanıp uzun yıllar kendine eziyet çektirebilir.Akrep kadını arkadaşlık ilişkilerinde iyidir. Haddini aşmaz, duracağı yeri iyi bilir. Elinden geldiği durumlarda yardımı esirgemez. Ancak kendisi ufak tefek şeyler için yardım istemeyecek, en doğru anı bekleyecek, belki de o an hiçbir zaman gelmeyecektir. Buna bir çeşit “Godmother” durumu da denilebilir. İnsanların kendisine minnet borcu hissetmesini sever. Arkadaşlık ilişkilerinde düzeyli olduğu için çok sayıda arkadaşı vardır.".ToString();
            textBox3.Text = "Akrep burcu kadını kendine yetebilmeyi sever. Kendine yetemezse başkalarının özel alanına müdahale etmesinden korkar. Çok fazla maddi beklentisi yoktur. Üretmeyi ve dönüştürmeyi bilir.  Tutumludur. Hayatı ciddiye almayan, gevşek ağızlı insanlardan ve kendisi ve yakın çevresi için tehdit oluşturabilecek kişilerden hoşlanmaz. Böyle kişileri hayatına sokmamak için gayret gösterir.".ToString();
            textBox4.Text = "Akrep burcu kadını kendisiyle ilgilenildiğini ve kadın olduğunun hissettirildiği parfüm, iç çamaşırı, çiçek vb hediyelere bayılır. Eğer akrep kadını arkadaşınız ise her zaman kullanabileceği deri bir kemer, bir cüzdan, kullanışlı bir gömlek, şık bir duvar aynası hediye ederek onu mutlu edebilirsiniz.".ToString();











        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 a = new Form10();
            a.Show();
            this.Hide();
        }
    }
}
