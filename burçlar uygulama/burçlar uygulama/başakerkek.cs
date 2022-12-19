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
    public partial class başakerkek : Form
    {
        public başakerkek()
        {
            InitializeComponent();
        }

        private void başakerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Âşık bir Başak erkeği Zodyak’ın havyarı, trüf mantarıdır; yani siz daha ziyade patates, hamburger, cips insanıysanız Başak erkeği sizin için iyi bir eş olmayabilir. Başak erkeğinin diğer insanlarla uyumu, partnerlerinin tüm sevgilerini onlara verme yeteneklerine bağlıdır. Bu sayede kendilerini güvende hisseder ve kırılgan, şefkatli yüreklerini karşılarındaki insana açabilirler. Nadiren sevgi gösterinde bulunsalar da samimi bir ilişki duygusal yanlarının güzelliğini ortaya çıkarır. Eğlence amaçlı, gelip geçici ilişkilerden ziyade uzun süreli ilişkileri tercih ederler.".ToString();
            textBox2.Text = "Başak erkekleri oldukça bilge ve zekidir, sorun çözmeyi severler. İlişkilerinde akıl hocası rolünü üstlenirler, bu nedenle de nadiren eşitlikçi bir ilişki olur. Dolayısıyla ilişkide kişisel sınırlara dikkat edilmeli ve bir denge bulunmalıdır.".ToString();
            textBox3.Text = "Merkür tarafından yönetilen Başak erkeği sürekli bilgi toplamak ve beyninin içindekileri düzenlemenin bir yolunu bulmakla meşguldür. Dünyayı kendi koşullarına uydurmayı sever ve etrafında huzurlu, düzenli, derli toplu bir alan yaratmaya çalışırlar. Zihnini meşgul edecek bir iş olmadığı zaman çabucak evhamlı birisine dönüşürler. Kendi sorumluluklarını üstlenmeyi ve başkalarına yardımcı olmayı severler ama hiçbir karşılık görmedikleri durumda da gücenirler.".ToString();
            textBox4.Text = "Başak erkeği, zor beğenen kişiliklerine hitap eden ve dış görünüşleriyle ilgili hediyeleri severler. Bu yüzden işlenmiş kemik taraklar, monogram kol düğmeleri güzel bir hediye olacaktır. Ismarlama giysiler, deri ciltli defterler, el yapımı mücevherler, antika bir mühür yüzüğü gibi hediyeler de hoşlarına gidecektir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            a.Show();
            this.Hide();

        }
    }
}
