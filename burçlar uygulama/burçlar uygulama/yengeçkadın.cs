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
    public partial class yengeçkadın : Form
    {
        public yengeçkadın()
        {
            InitializeComponent();
        }

        private void yengeçkadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Gerçekten âşık olan Yengeç kadınları, bir girdaba kapılarak sizi geri kalan dünyanın ortadan kaybolduğu gizli bir bölgeye götürürler. İlk başta harika gibi görünse de bu tür ilişkiler çoğu zaman sembiyotik, bağımlı ilişkilere evrilir. Bu burcun kadınları doğuştan başkalarını mutlu etmeye isteklidir ve size yaptıkları şeylerin takdir edilmesini isterler. Zaman zaman sergiledikleri melodramların haricinde, Yengeç kadınıyla aşk yaşamak son derece doyurucu bir deneyim olabilir.".ToString();
            textBox2.Text = "Yengeç kadınları ilişkilerinde, sevdiklerine karşı sevgi dolu ve tutkulu olma eğilimindedirler. Bir kez bağlandıklarında yalnızca bir kişiyle derin bir bağ kurmak isterler. Bir Yengeç kadını aşkı bulduğu zaman arkadaşlar ve diğer ilişkiler bir kenara atılır; bu ilişkileri görmezden gelmek de sıklıkla Yengeç tükenmesiyle sonuçlanır.".ToString();
            textBox3.Text = "Yengeç kadınının kendini en mutlu hissettiği yer evidir; ev onun için rahatlama ve tazelenme kaynağıdır. Dinlenebileceği ve güzel yemekler yiyebileceği sessiz bir ortam arayışında olan Yengeç kadını kalabalık sokaklardan, gürültücü komşulardan hoşlanmaz ve genel olarak su kenarında yaşamayı ister.".ToString();
            textBox4.Text = "Yengeç burcu kadını için en güzel hediye, en sevdiği markayı ve giyim tarzını bir kenara not edip bedenine uygun bir giysi almaktır. Antik mücevherler de nostaljik bir karakteri olan Yengeç kadınları için güzel bir seçimdir. Aileden birinden yadigar bir mücevher de şahane bir hediye olacaktır.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 a = new Form6();
            a.Show();
            this.Hide();


        }
    }
}
