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
    public partial class kovaerkek : Form
    {
        public kovaerkek()
        {
            InitializeComponent();
        }

        private void kovaerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Kova erkekleri çoğu zaman tuhaf bir espri anlayışına sahiptir; bu espri anlayışını flört ettikleri kişileri baştan çıkarmak için kullanırlar ve aynı anda birkaç kişiyle flört edebilirler. Müzmin bekarlıkları ile nam salmış Kova erkeklerinin tuhaf yanlarıyla başa çıkmak uzun vadede zor olabilir.".ToString();
            textBox2.Text = "Kova erkekleri toplumun standartlarına ve beklentilerine uymayı reddeden özgün insanlardır. Bu özgünlükleri kıyafet, meslek ya da siyasal bakış açısı seçimlerinde görülebilir ama daha ziyade eş seçimlerinde ortaya çıkar. Her daim kendilerinden daha sıra dışı insanlarla birlikte olmayı isterler.".ToString();
            textBox3.Text = "Kova burcu erkeği pek çok insan tarafından merak edilen ama çok az insan tarafından gerçekten anlaşılan insanlardır. Bunun sebebi büyük ölçüde Kova erkeklerinin çoğu zaman ya zamanının çok ötesinde olmaları ya da çoğu insanın duymaya hazır olmadığı radikal fikirlere sahip olmalarıdır. Çoğu zaman toplumdan dışlanmış hissederler. Kendileri gibi düşünen, onlar gibi ileriyi gören insanların yanındayken mutlu olurlar.".ToString();
            textBox4.Text = "Kova erkeğinin tuhaf şeyleri biriktirmek gibi bir alışkanlığı vardır. Güzel bir tıraş makinesi gibi bir hediye de onu mutlu edebilir ama eski zamanlardan kalma görünümlü bir teleskop, antika gözlük gibi sıra dışı şeyler daha çok hoşuna gidecektir. Ayrıca entelektüelliğe önem veren Kova erkekleri için kitaplar, dergiler, çizgi romanlar da güzel bir seçenek olabilir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 a = new Form13();
            a.Show();
            this.Hide();
        }
    }
}
