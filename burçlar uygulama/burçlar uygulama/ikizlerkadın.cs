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
    public partial class ikizlerkadın : Form
    {
        public ikizlerkadın()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();


        }

        private void ikizlerkadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "İkizler burcu kadını çoğunlukla sapyoseksüeldir; keskin bir zekâyı çekici bulur. Tatlı ve şapşal bir sevgili, İkizler burcu kadını için uygun değildir. Onun iletişim yeteneklerine ayak uydurabilen, kelime oyunlarına, şakalarına eşlik edebilecek birini ister.".ToString();
            textBox2.Text = "Bu zeki kadın için fikirlerin uyuşması son derece önemlidir; fikirler diyarında eşini bulduğu zaman heyecan ve enerjiyle dolar. Esprilerine eşlik etmeye istekli, ani fikir değişimlerine de hazırlıklı olmalısınız; tartışma esnasında şeytanın avukatına dönüşebilir. Ayrıca tüm gece sohbet etmeye de hazır olun; her zaman konuşacağı bir konu vardır".ToString();
            textBox3.Text = "İkizler burcu kadınları alışveriş yapmayı ve yeniliği severler. Pahalı ya da havalı şeyler almasına gerek yoktur; aldıkları yeni şeyleri genelde ikinci el pazarlarından, kermeslerden toplarlar. Eşyalarının çoğuna bağlılık duymazlar ve cömert kişilikleri nedeniyle sahip oldukları şeyleri ihtiyacı olan komşularına, arkadaşlarına vermeyi severler.".ToString();
            textBox4.Text = "İkizler burcu kadınına hediye almak başlı başına bir zevktir; genelde ne hediye alırsanız alın mutlu olurlar. Sıra dışı nesnelerden hoşlanırlar, bilhassa bu nesnenin ilginç bir hikâyesi varsa. İkizler kadınını etkilemek için çok para harcamanıza gerek yoktur – bir sürü ıvır zıvırın bulunduğu bir dükkâna götürmek, pahalı bir hediyenin ambalajını açmaktan daha fazla mutlu edecektir.".ToString();


        }
    }
}
