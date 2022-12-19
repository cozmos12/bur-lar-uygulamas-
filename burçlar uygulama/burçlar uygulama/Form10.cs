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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            textBox1.Text = "su".ToString();
            textBox2.Text = "sabit".ToString();
            textBox3.Text = "plüton (güç gezezgeni)".ToString();
            textBox4.Text = "kırmızı bordo".ToString();
            textBox5.Text = "salı".ToString();
            textBox6.Text = "8,11".ToString();
            textBox7.Text = "yakut,opal".ToString();
            textBox8.Text = "Başkalarının hayatına dair her şeyi bilmek, tam bir kontrole sahip olmak.".ToString();


            textBox9.Text = "Burçlar üç farklı niteliğe göre gruplanır: kardinal (öncü), değişken ve sabit burçlar. Akrep burcu dört sabit burçtan biridir; diğer dört sabit burç ise Boğa, Aslan ve Kovadır. Bu burçlar her mevsimin ortasına denk gelir. Bunlar dengeleyici burçlardır; kendilerine bir amaç belirler ve sonra da inşa etmeye başlarlar. Öncü burçların öne attığı heyecanlı fikirleri alır, bunları somut bir şeye dönüştürürler.Akrep burcu su elementine bağlı üç burçtan biridir (diğerleri Yengeç ve Balık’tır). Akrep Zodyak’ın ikinci su burcudur. Görevi kendisinin ve başkalarının duygularını güçlendirmek ve kalıcı hale getirmektir. Diğer su grubu burçları gibi akrep de duyguları deneyimlemek ve ifade etmek için yaşar ancak duygulara çok önem verse de dışarıdan belli etmemesi ile diğer su gruplarından farklıdır. Akrep burcunun pek çok sırrı vardır ve daima sırlarını başkalarından saklayarak yaşar.Akrep burçları tutkulu ve iddialı kişilerdir. Gerçeği öğrenene kadar araştırmak en belirgin özelliklerindendir. Kararlı ve belirleyicidirler. Gerçeğin daima farkında olan ve hayallerden ziyade hedeflere odaklanan akrepler evrenin kurallarını çok iyi bilirler. Bu nedenle başkaları tarafından genellikle sert ve şiddetli bulunurlar ancak bu gerçekçi tutum onlara doğal bir şekilde öne çıkmalarını sağlayan liderlik özelliği verir.Akrep burcu belki de en yanlış anlaşılan ve en gizemli burçlardan biridir. Doğaları gereği kapalı kutu olan bu burç, genelde yüzleşmeye cesaret edemediğimiz karanlık ve saklı yerlerimizle karşılaştırır bizi. Yaşam, ölüm ve yeniden doğuşun burcu olan Akrep burcunun enerjisi hayatın bu döngülerini kucaklar ve sürekli olarak kendini dönüştürerek yeniden üretir. Akrep burcu dört farklı şekilde vücut bulur: paylaşmayı sevmeyen, zehirli akrep şeklinde; kaygan, büyüleyici ama ölümcül yılan şeklinde; delici bakışlarıyla etrafı  ve avını izleyen kartal şeklinde; son olarak da sürekli yanan ve her şeyi gören, küllerinden doğan Zümrüdüanka kuşu şeklinde. Akrep burcu gezegen geçişi sırasında yoğun duygularla ve yoğun bir enerjiyle uğraşırken bulabiliriz kendimizi. Akrep enerjisinin özü çekici, tutkulu, sadık, koruyucu, akım belirleyici, kontrolcü, güçlü, karizmatik, dikkatli, şifalı, psişik ve cesur olmaktır. Öte yandan negatif Akrep enerjisi de takıntılı, aşırı sahiplenici, kıskanç, ketum, kindar, acımasız, içten pazarlıklı ve manipülatif olabilir.".ToString();










        }

        private void geri_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            akrepkadın a = new akrepkadın();
            a.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            akreperkek a = new akreperkek();
            a.Show();
            this.Hide();
        }
    }
}
