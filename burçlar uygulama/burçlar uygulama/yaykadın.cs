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
    public partial class yaykadın : Form
    {
        public yaykadın()
        {
            InitializeComponent();
        }

        private void yaykadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Âşık bir Yay kadını tutkulu, enerjik ve her şeye hazırdır. Doğanın gerçek gücü olan Yay burcu kadını elinde yayı ve okuyla ormanlarda avının peşinde koşan, avcı Artemis’e benzer. İstediği şeyin peşinden gitmekten büyük keyif alır. Oturup hoşlandığı kişinin ona yaklaşmasını beklemeyi sevmez, ilk adımı kendisi atar.".ToString();


            textBox2.Text = "Bazı insanlar Yay burcu kadınının kaba ve doğrudan tavırlarından rahatsız olabilirler. Yay burcu kadınları, onların enerjisine ve dobra tavırlarına uyum sağlayamayan insanlara karşı sabırsızdır. Ne yazık ki bazı insanlar bu kadınlar gücü karşısında sinip kalır ve bağımsız tavırlarının altında ezilirler. Dolayısıyla her ne kadar herkes tarafından sevilseler de Yay burcu kadınları genelde uzun yıllar boyu yalnız kalabilir.".ToString();
            textBox3.Text = "Bilinmeyen yerler, yeni insanlar, yeni fikirler ve yeni maceralar keşfetmek için can atan Yay burcu kadını özgür bir kadındır; hayatında modası geçmiş toplumsal cinsiyet rollerine ya da toplumsal tabulara yer yoktur. İstediği şeyi istediği zaman yapar ve bunun hakkında ne düşündüğünüzü umursamaz.".ToString();
            textBox4.Text = "Yay burcu kadınlarının en sevdiği şey tuhaf bir hikâyesi olan hediyelerdir. Ayrıca yaratıcı yönlerini kullanmayı ve şimdiki zamanın ötesindeki gerçeklikleri tasavvur etmeyi severler. Dolayısıyla başka bir ülkeden gelen, özel bir hikâyesi olan hediyeler oldukça hoşlarına gidecektir.".ToString();







        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11 a = new Form11();
            a.Show();
            this.Hide();
        }
    }
}
