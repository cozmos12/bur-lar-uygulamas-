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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ateş".ToString();
            textBox2.Text = "Sabit".ToString();
            textBox3.Text = "Güneş".ToString();
            textBox4.Text = "Altın sarısı".ToString();
            textBox5.Text = "Pazar".ToString();
            textBox6.Text = "1,3".ToString();
            textBox7.Text = "Akik,kehribar".ToString();
            textBox8.Text = "Dünyayı yönetmek".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Aslan burcu dört sabit burçtan biridir; diğer dört sabit burç ise Boğa, Akrep ve Kova’dır. Bu burçlar her mevsimin ortasına denk gelir. Bunlar dengeleyici burçlardır; kendilerine bir amaç belirler ve sonra da inşa etmeye başlarlar. Öncü burçların öne attığı heyecanlı fikirleri alır, bunları somut bir şeye dönüştürürler.Aslan burcu ateş elementiyle yönetilen üç burçtan biridir (diğer ikisi Koç ve Yay’dır). Zodyak’ın ikinci ateş burcu Aslan olduğu için, Aslan burcunun sıcaklığı, bir kıvılcımı herkesin hissettiği büyük bir yangına dönüştürür. Pek çok Aslan burcu doğuştan sanatçı ve liderdir. Aslan burcu gezegen döngüsünün etkisi altındayken hepimiz sahne ışıklarını üzerimize çekme arzusuyla yanıp tutuşuruz. Aynı zamanda insanların damarına basan, fazla talepkâr, patronluk taslayarak insanları çıldırtan kişilere dönüşebiliriz.Ateş elementine bağlı olan Aslan burcu cana yakın ve hayat doludur; her zaman gülmeye ve güzel zaman geçirmeye çalışır. En zor problemleri bile çözebilecek bir zekâya sahip olabilen Aslan burcu pek çok karmaşık durumun çözümünde kolaylıkla inisiyatif alır. Evrenimizin merkezinde duran Güneş tarafından yönetilen Aslanlar öz farkındalık arayışı içindedirler ve egoları sürekli olarak büyür (Güneş de egoyu ve maskülen enerjiyi temsil etmektedir). Arzularının ve kişiliklerinin farkında oldukları için ihtiyaç duydukları her şeyi kolayca isteyebilirler ama bir o kadar kolayca da başka insanların ihtiyaçlarını görmezden gelebilirler. Bir Aslan burcu kazanımlarına ve diğer insanların bu kazanımları nasıl gördüğüne çok kafayı takarsa kolay lokma haline gelir, çabucak alaşağı edilebilir.Aslan enerjisi doğal olarak dışavurumcu ve şaşaalıdır. Bizi en çok istediğimiz projelerimiz ve sevdiklerimiz konusunda koruyucu kılar. Yüreğimiz tarafından yönetilmemizi sağlar. Aslan burcu gezegen geçişi sırasında arzularımızın şaşaasına teslim olur, dışavurumcu hale gelebiliriz. Aslan enerjisi etrafımızdaki insanları hor görmemize, bir gruptaki her bireyin değerli olduğunu unutmamıza sebep olabilir. Yine de Aslan sezgilerini güçlü bir liderliğe sevk edebilir ve herkesin gün ışığından nasiplenmesine izin verebiliriz. Doğru kullanıldığında Aslan enerjisi diğer insanları uyandırır, canlandırır ve güçlendirir.".ToString();










        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            aslankadın a = new aslankadın();
            a.Show();
            this.Hide();
             


        }

        private void button2_Click(object sender, EventArgs e)
        {
            aslanerkek a = new aslanerkek();
            a.Show();
            this.Hide();


        }
    }
}
