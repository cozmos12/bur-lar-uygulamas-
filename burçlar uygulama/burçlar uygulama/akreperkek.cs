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
    public partial class akreperkek : Form
    {
        public akreperkek()
        {
            InitializeComponent();
        }

        private void akreperkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Akrep burcu erkeği kadınına göre aşka daha açıktır ve özellikle gençlik döneminde yaşayabileceği kadar fazla çeşitlilikte ilişki yaşamaya çalışır. Cazibelidir. Sözel zekası gelişmiş olan Akrep erkeği edebiyat ve sinema sevgisi, yerinde imalar ve komplimanlar yaparak karşı cinsi kolaylıkla etkileyebilir. Aşık olursa uzun yıllar sadık kalır.  Bazen takıntılı ve şüpheci davranışları olabilir. Partnerinin üstüne fazla düşerek bezdirebilir.".ToString();
            textBox2.Text = "Akrep burcu erkeğinin tahmin edemeyeceğiniz kadar farklı dünyalardan kişilerle tahmin edemeyeceğiniz kadar karmaşık ilişkileri bulunabilir. Bu hem aşk hem arkadaşlık için geçerlidir. İlişkileri üzerine konuşmayı sevmez. Gizemli bir hava yaratmayı iyi bilir ve bundan beslenir.".ToString();
            textBox3.Text = "Akrep burcu erkeği kimseyle paylaşmasa da “ünlü olma, herkesçe bilinme, bir eser bırakma” isteğini şiddetli bir şekilde hisseder. Bu nedenle önemli insanlara yakın olmaya çalışır. Tıpkı Akrep kadını gibi kendi yağında kavrulmayı sever. Kendisini itibarsızlaştıran veya çok fazla sorgulayan insanlardan hoşlanmaz ve onları hayatına sokmamak için gayret gösterir.".ToString();
            textBox4.Text = "Sevdiği bir romanın ilk baskısı, yıllanmış kaliteli bir şarap, farklı bir mekanda akşam yemeği onu fazlasıyla mutlu edecektir. Günlük hayatta kullanabileceği saat, cüzdan, kemer, gömlek gibi hediyeler de iş görür. Önemsendiğini hissetmek akrep erkeğini mutlu etmek için yeterlidir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form10 a = new Form10();
            a.Show();
            this.Hide();
        }
    }
}
