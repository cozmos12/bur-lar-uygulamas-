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
    public partial class koç_erkek : Form
    {
        public koç_erkek()
        {
            InitializeComponent();
        }

        private void koç_erkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Koç burcu erkeği âşıksa eğer öyle ya da böyle anlarsınız. Bu durumdayken davranışlarının iki ucu vardır. Bir savaşçı olarak aşkı için, istediği kişinin kalbi için savaşma ihtiyacı hisseder ve bu yolda onu hiçbir şey durduramaz. Yani ilgilendiği kişinin dikkatini kazanma çabasında ısrarcıdır. Diğer uçta ise Koç burcu erkeği kendi duygularını anlamaktan aciz bir adama dönüşür. Bu da onu mesafeli, hatta öfkeli hale getirir. Ne hissettiğini anlatamaz, konuşma yetisini kaybetmiş birine döner.".ToString();
            textBox2.Text = "Genel olarak Koç burcu erkeği için ilişkiler kolay değildir. Sevgilisiyle iletişim kurmak, merhamet duymak ve iki kişi için düşünmek gerektiğinde zorlanırlar. Her şeyi tek başlarına yapmayı severler ve onların liderliğini takip edecek kadar enerjik bir sevgili bulmanın zor olduğunu düşünürler. Koç burcu erkeğiyle sağlıklı bir ilişki yaşamak istiyorsanız, maddi ve manevi anlamda bağımsız kalabilmeniz önemlidir.".ToString();
            textBox3.Text = "Koç burcu erkeği çekici, güçlü ve özgüvenlidir. Yeni ve heyecan verici şeylere her zaman hazırdır. İlk adımı atmaktan çekinmez. Bununla beraber kendinden başka kimse için pek bir şey hissetmez. Kaba, bencil ve itkisel olabilir. Her ilişkiye kendi üstünlüğünü ispat edeceği bir savaş arenası muamelesi gösterebilir.".ToString();
            textBox4.Text = "Keskin, kırmızı renkli şeyleri severler. Hediye olarak bir İsviçre çakısı, bir alet seti alabilirsiniz. Erkeksiliğini vurgulayan hediyeler hoşuna gider. Alacağınız hediye üzerinde çok düşünmeye gerek yok; o da sizinki üzerinde çok düşünmeyecektir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
            this.Hide();


        }
    }
}
