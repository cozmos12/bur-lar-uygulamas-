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
    public partial class yengeçerkek : Form
    {
        public yengeçerkek()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void yengeçerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Yengeç erkekleri âşık oldukları zaman adanmış bir sevgili olurlar. Size olan hayranlığını abartılı tavırlarla gösteren, aşk mektupları yazan beyaz atlı prens gibi çıkagelirler. Bir kez karşılıklı saygıya dayalı bir ilişki oturtabildiğinde, sevgilileriyle olan bağları heyecanlı olmaktan ziyade samimi bir hale gelir. Yengeç erkekleri inanılmaz derecede sahiplenici ve kıskançtır. Sahip olduklarının ellerinden kaçıp gitmesinden korkarlar.".ToString();
            textBox2.Text = "Yengeç erkekleri ana kuzusu olma eğilimindedir; buna hazırlıklı olun. Öte yandan ailenizle tanıştırmaya en uygun adaydır: Akşam yemeğini yerken tüm görgü kurallarını eksiksizce sergiler; aperitifler geldiğinde çoktan annenizi de babanızı da sizin şimdiye kadar birlikte olduğunuz kişiler arasından en iyisi olduğuna ikna etmiş olacaktır.".ToString();
            textBox3.Text = "Yengeç erkekleri tam bir ev kuşudur; kişisel alanlarına derinden bağlıdırlar ve büyük bir kanepenin üzerinde gevşemeyi severler. Eve geldiğinde eşofmanlarını çekip rahatlamaktan ve yan gelip yatmaktan zevk alırlar.".ToString();
            textBox4.Text = "Yengeç erkekleri eski ve sıra dışı şeylere bayılır, bilhassa sahip oldukları şeyin başkalarında olmadığını biliyorsalar çok mutlu olurlar. Ay tarafından yönetilen Yengeç erkekleri genelde feminen tabiatlarıyla daha içli dışlıdırlar; dolayısıyla güzel kıyafetler ve aksesuarlar alabilirsiniz. Çoğu zaman el yapımı gümüş yüzükler gibi mücevherlerden hoşlanırlar. Lavanta gibi çiçeksi ya da şekerli kokulardan oluşan kokular da hoşlarına gidecektir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();
             

        }
    }
}
