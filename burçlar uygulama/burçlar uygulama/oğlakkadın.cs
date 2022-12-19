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
    public partial class oğlakkadın : Form
    {
        public oğlakkadın()
        {
            InitializeComponent();
        }

        private void oğlakkadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Oğlak kadınları gençlik yıllarında bile her ilişkisini sonsuza kadar sürmeyecek bir ilişki olarak görmekte güçlük çekerler. Daha ilk buluşmada karşısındaki kişiyle yaşlandıklarında neye benzeyeceklerini düşünürler.Ciddiyetsizlikten hoşlanmayan ve ciddi bir ilişki isteyen Oğlak kadını için sevgili olmak genellikle kafa karıştırıcıdır. Yakın arkadaşlarına, uzun süredir hayatında bulunan insanlara âşık olma ihtimali yüksektir. İlk bakışta aşk pek mümkün değildir; bir Oğlak kadının sizi sevdiğini fark etmesi uzun zaman alabilir.".ToString();
            textBox2.Text = "Cinsel açıdan, Oğlak kadının vahşi yanını görmeye hazırlıklı olun; doymak bilmez iştahı ve yabani tarafının tadına bakmaktan çekinmemesi ile Oğlak kadını, gündelik hayatta dominant olsa da sevişme esnasında kontrolü zaman zaman bırakmayı da tercih edebilir.".ToString();
            textBox3.Text = "Taliplilerinin gösterdiği ilgiye kayıtsız olan Oğlak kadını sizden son derece direkt olmanızı ve dosdoğruca çıkma teklifi etmenizi bekliyor olabilir. Ancak bu şekilde onun için bir şey hissedip hissetmediğinizi bilebilir. Yoksa sizin üstü kapalı çabalarınızı fark etmeyebilir.".ToString();
            textBox4.Text = "Genel olarak dört dörtlük bir canlı olan Oğlak burcu kadını etrafındaki her şeyin öyle olmasını ister ve çoğu zaman kılı kırk yararak oluşturduğu A Planı’ndan bilmediği bir B Planı’na ani geçişlerden hoşlanmaz – B Planı daha iyi bir seçenek olsa bile. Ciddi ve çalışkan olan Oğlak burcunun eğlenceye ayırdığı zaman bile dikkatli ve önceden planlanmıştır.".ToString();







        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form12 a = new Form12();
            a.Show();
            this.Hide();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
