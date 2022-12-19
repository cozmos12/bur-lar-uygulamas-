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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            yengeçkadın a = new yengeçkadın();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            yengeçerkek a = new yengeçerkek();
            a.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            textBox1.Text = "su".ToString();
            textBox2.Text = "kardinal (öncü)".ToString();
            textBox3.Text = "Ay(duguları yaöneten gezegen)".ToString();
            textBox4.Text = "Beyaz".ToString();
            textBox5.Text = "pazartesi,perşembe".ToString();
            textBox6.Text = "2,3".ToString();
            textBox7.Text = "Ay taşı,kuvars".ToString();
            textBox8.Text = " Arkadaşlarına ve ailelerine göz kulak olmak".ToString();
            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Yengeç burcu dört kardinal burçtan biridir. Bu burçlar mevsimleri başlatır. Koç, baharı; Yengeç, yazı; Terazi, sonbaharı; Oğlak ise kışı başlatır. Bu burçlar özgün olmayı severler ve yaptıkları her şeyde birinci olmayı isterler. Akım belirleyicidirler; arkadaş ortamlarında partileri, organizasyonları onlar başlatır.Yengeç burcu, tıpkı Akrep ve Balık gibi su elementine bağlıdır. Zodyak’ın ilk su burcu olduğu için, duygu denizinin ve yaratıcı suların akmasını sağlayan bir nehir gibidir. Yengeç burcu insanları etrafındaki herkesin mutlu olmasını ister. Yengeç gezegen döngüsü etkisi altındayken ailemizle ve sevdiklerimizle vakit geçirme ihtiyacı hissederiz.Duyguları ve kalpleri tarafından yönetilen Yengeçler kalabalığa karışmakta güçlük çekerler. Yengeç burcu Dünya’ya en yakın, duygularımızı en çok etkileyen, iç benliğimizi yöneten, derin arzularımızı ve duygusal isteklerimizi ortaya çıkaran bir gök cismi olan Ay tarafından yönetilir; Ay döngüsünün fazları Yengeçlerin içsel gizemlerini derinleştirir ve onların kontrolü dışında, kısa süreli duygusal örüntüler yaratır. Hayatlarının ileriki dönemlerinde ruhsal çalkantılar nedeniyle sabırsızlık, sevgisizlik, bencillik, kendine acıma veya manipülasyon gibi huylar ortaya çıkabilir. Öte yandan hayatlarından memnun oldukları dönemlerde başkalarına yardım etmeyi, çatışmadan kaçınmayı severler.Yengeç enerjisi, tıpkı bir yengeç kıskacı gibi, iş güvenliğinden aile üyelerine kadar rahatlığa dört elle sarılmamıza sebep olur. Ayrıca tıpkı yengecin evini sırtında taşıması gibi, Yengeç burcu insanları da nereye giderseler gitsinler kendilerine güvenli ve rahat bir ortam yaratmaya çalışırlar. Değişim, kök salmayı seven bu burcu huzursuz eder.Yengeç burcu gezegen geçişi sırasında kendimizi duygusal ve nostaljik hissedebiliriz. Duygular ve sezgiler mantığın ve zekânın önüne geçer. Bu dönemler kendimizi ve sevdiklerimizi beslememiz gereken dönemlerdir. Yengeç enerjisi ruhun gıdasıdır ve bir kez bu gıdanın tadına baktığınızda sakinleşmiş, doymuş hissedersiniz.".ToString();







        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();



        }
    }
}
