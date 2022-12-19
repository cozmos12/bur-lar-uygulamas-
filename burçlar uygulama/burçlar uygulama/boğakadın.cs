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
    public partial class boğakadın : Form
    {
        public boğakadın()
        {
            InitializeComponent();
        }

        private void boğakadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Sadık bir dost, cana yakın bir sevgili olan Boğa kadını hayatınızın sonuna kadar size bağlı kalır – tabii, kırmızı çizgilerini aşmazsanız. Kırmızı çizgilerini aştığınız zaman ise boynuzlarını size yöneltmesine hazır olun. Boğa kadını oldukça esprili, şakacı ve müstehcendir. Boğa kadınıyla yaşayacağınız ilişki yürekten, samimi bir ilişki olacaktır.".ToString();
            textBox2.Text = "Eğer onu hak ettiği şekilde severseniz, hayatınızın sonuna kadar sizinle birlikte olur. Boğa burcu kadınları ilişkilerinde sabit ve güvenilirdir. Güvenini kazandığınız taktirde sizinle olan ilişkisini mutlu bir ilişkiye dönüştürebilmek için elinden gelen her şeyi yapacaktır.".ToString();
            textBox3.Text = "Boğa kadını pratikliğini nezaket tutkusuyla birlikte ustalıkla birleştirir. Biçim ve işlevin uyumlu bir biçimde bir araya getirilebileceğini ustalıkla gösterirler. Sağlık Boğa kadını için önemlidir; dans etmeyi, yoga yapmayı ya da spor yapmayı severler. Doğayla barışık olan Boğa kadınını bahçede çiçek yetiştirirken, hayvan dostlarını severken ya da vahşi doğada kamp yaparken bulmanız mümkündür. Bir şey pişirirken genelde sağlıklı ve ev yapımı yemekler yapmayı tercih ederler. Zarif ve aklı başında, duygusal ve duyarlı, lüks düşkünü ama asla ellerini kirletmekten çekinmeyen Boğa kadınlarının harika bir stili vardır.".ToString();
            textBox4.Text = "Boğa kadınını bir hediyeyle etkilemek istiyorsanız el yapımı ve eşi benzeri olmayan bir şey seçebilirsiniz. Ucuz, plastik ya da toplu üretim işi şeylerden hoşlanmayacaktır. Bitkisel karışımlar, doğal vücut ürünleri ya da ahşaptan/kilden yapılma güzel bir şey daha fazla hoşuna gidecektir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 a = new Form4();
            a.Show();
            this.Hide();
        }
    }
}
