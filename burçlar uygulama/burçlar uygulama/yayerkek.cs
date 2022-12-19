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
    public partial class yayerkek : Form
    {
        public yayerkek()
        {
            InitializeComponent();
        }

        private void yayerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Yay burcu erkekleri âşık oldukları zaman büyüleyici olurlar. Ama bu son derece kendine güvenen erkeklere âşık olduğunuz zaman dikkatli olun çünkü her daim av peşinde olacaklardır. Yay burcu için avlanmak her şeydir; flört ve arzunun dansını sergilemek üzere yaşarlar. Gidenin ardından yıllarını harcayıp yanında olan kişiyi görmezden gelebilirler. Zaman zaman da adanmışlıkları bu anlaşılmaz avcıları çekingen kılabilir.".ToString();
            textBox2.Text = "Yay burcu insanları son derece eğlenceli ve esprilidir; bu da demektir ki partnerleriyle eğlenceli zamanlar geçirmekten keyif alırlar. Tutkulu, neredeyse her şeyi denemeyi isteyen Yay burcu erkeklerine en çok hitap eden partnerler, onlar kadar açık fikirli olan partnerlerdir.".ToString();
            textBox3.Text = "Son derece sosyal olan Yay burcu erkekleri kros kayağı, avlanmak, ilginç aşk maceraları gibi heyecan verici deneyimlerin peşinden koşmayı severler. Asla yola gelip evde oturup kalmaktan hoşlanmazlar. Çoğu zaman göçebe bir hayat sürer, oradan oraya dolaşır ve nadiren evlerine birilerini çağırırlar.".ToString();
            textBox4.Text = "Yay burcu erkeğine hediye alıyorsanız, az eşyayla seyahat etmeyi sevdiğini unutmayın. Ağır, hacimli ya da taşınması zor bir hediye almamaya dikkat edin. Güzel bir deseni olan, pratik ve taşıması kolay bir valiz hoşuna gidecektir, bilhassa sipariş üzerine yaptırılmış bir hediyeyse. Çok amaçlı alet edevatlar, zekice işlevleri olan eşyalar da oldukça ilgilerini çeker.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 a = new Form11();
            a.Show();
            this.Hide();
        }
    }
}
