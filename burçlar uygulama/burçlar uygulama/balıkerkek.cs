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
    public partial class balıkerkek : Form
    {
        public balıkerkek()
        {
            InitializeComponent();
        }

        private void balıkerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Balık burcu kadınına göre daha sakindirler, duygularını daha az belli ederler ama bu onları duygusuz yapmaz, sadece derinde yaşarlar. Daldan dala konuyorlarmış gibi görünseler de aradıkları şey anlaşabilecekleri ve güvenebilecekleri kişiyi bulmaktır her insan gibi, sadece yöntemleri biraz zorlayıcı görünebilir.".ToString();
            textBox2.Text = "Dengesizliği nedeniyle Balık erkekleri sıklıkla incinir ve hislerinin incindiğini hemen belli ederler. Hislerine karşılık bulamadıkları zaman Balık burcu erkekleri için ilişkinin kurbanıymış gibi hissetmek çok kolaydır.".ToString();
            textBox3.Text = "Neptün tarafından yönetilen bu hayalperestler, duygusal olarak da, spiritüel olarak da, entelektüel olarak da derinlere dalmayı severler ve asla sığ sularla yetinmezler. Havadan sudan konuşmak hoşlarına gitmez; ilk kez gittikleri bir buluşmada bile size kendinizle ilgili sorular sorup bu konu hakkında saatlerce konuşabilir.".ToString();
            textBox4.Text = "Doğal ve değerli taşlardan yapılma mücevherler hoşlarına gidebilir çünkü Balık burcu erkekleri çoğunlukla içlerindeki feminen tarafları keşfetmekten çekinmezler. Güzel kokmayı sevdikleri için parfüm sıkmaktan, çeşitli yağlar kullanmaktan hoşlanırlar. Pek çok Balık burcu erkeği kişisel temizlikleri konusunda titiz oldukları için kokulu banyo ve vücut ürünleri, suya bayılan bu burç için epey güzel bir seçenek olabilir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 a = new Form14();
            a.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
