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
    public partial class ikizlererkek : Form
    {
        public ikizlererkek()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }

        private void ikizlererkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Âşık bir İkizler erkeği her zaman kafa karıştırıcıdır. Bu burcun değişken mizacı ve baş döndüren zekâsı, aklı başında ve stabil sevgililerden çabuk sıkılan insanlar için şahanedir. Sosyalleşmeyi, partilere katılmayı seven biriyseniz, evde sessiz sessiz oturmayı sıkıcı bulan İkizler erkeği sizin için iyi bir eş olacaktır.".ToString();
            textBox2.Text = "İkizler burcu erkeğinin ajandası hep dolu olduğu için onu kesin bir plan yapmaya ikna etmek zordur. Sizinle sürekli iletişim halinde kalsa da unutmayın ki iletişim halinde olduğu tek kişi siz olmayabilirsiniz. İkizler erkeği aynı anda birden fazla kişiyi idare etmesiyle meşhurdur. Kimsenin kalbini kırmak istediğinden değil; sadece gerçekliği algılama biçimi bazen gerçekte olan bitenle çatışma halinde olduğu için böyle davranır.".ToString();
            textBox3.Text = "İkizler burcu erkeği sürekli dolaşır; seyahat ederken bile o koltuktan bu koltuğa geçer. Dur durak bilmeyen zihninin yeni bilgilerle meşgul edilmeye ihtiyacı vardır. Bu nedenle kafa karıştırıcı filmleri ya da oyunları seyretmeyi sever. İzleyiciyi ters köşeye yatıran, merakını canlı tutan gizem ve gerilim filmlerini sever.".ToString();
            textBox4.Text = "Tüm burçların arasından hediye alınması en kolay olan burç İkizler burcudur. İkizler burcu erkeği yeniliğe ve teknolojiye bayılır. Bir tomar para ödenmiş hediyelerdense küçük ve eğlenceli ıvır zıvırlar daha çok hoşuna gidecektir. Kitaplar her zaman için İkizler erkeğinin favorisidir; sevdiği bir dergiye abonelik yaptırmak, sevdiği bir kitapçıdan hediye kartı almak hoşuna gidecektir. Beraber oynamak için de yapboz ya da kutu oyunu gibi hediyeleri de tercih edebilirsiniz.".ToString();





        }

        private void ikizlererkek_Load_1(object sender, EventArgs e)
        {
            textBox1.Text = "Âşık bir İkizler erkeği her zaman kafa karıştırıcıdır. Bu burcun değişken mizacı ve baş döndüren zekâsı, aklı başında ve stabil sevgililerden çabuk sıkılan insanlar için şahanedir. Sosyalleşmeyi, partilere katılmayı seven biriyseniz, evde sessiz sessiz oturmayı sıkıcı bulan İkizler erkeği sizin için iyi bir eş olacaktır.".ToString();
            textBox2.Text = "İkizler burcu erkeğinin ajandası hep dolu olduğu için onu kesin bir plan yapmaya ikna etmek zordur. Sizinle sürekli iletişim halinde kalsa da unutmayın ki iletişim halinde olduğu tek kişi siz olmayabilirsiniz. İkizler erkeği aynı anda birden fazla kişiyi idare etmesiyle meşhurdur. Kimsenin kalbini kırmak istediğinden değil; sadece gerçekliği algılama biçimi bazen gerçekte olan bitenle çatışma halinde olduğu için böyle davranır.".ToString();
            textBox3.Text = "İkizler burcu erkeği sürekli dolaşır; seyahat ederken bile o koltuktan bu koltuğa geçer. Dur durak bilmeyen zihninin yeni bilgilerle meşgul edilmeye ihtiyacı vardır. Bu nedenle kafa karıştırıcı filmleri ya da oyunları seyretmeyi sever. İzleyiciyi ters köşeye yatıran, merakını canlı tutan gizem ve gerilim filmlerini sever.".ToString();
            textBox4.Text = "Tüm burçların arasından hediye alınması en kolay olan burç İkizler burcudur. İkizler burcu erkeği yeniliğe ve teknolojiye bayılır. Bir tomar para ödenmiş hediyelerdense küçük ve eğlenceli ıvır zıvırlar daha çok hoşuna gidecektir. Kitaplar her zaman için İkizler erkeğinin favorisidir; sevdiği bir dergiye abonelik yaptırmak, sevdiği bir kitapçıdan hediye kartı almak hoşuna gidecektir. Beraber oynamak için de yapboz ya da kutu oyunu gibi hediyeleri de tercih edebilirsiniz.".ToString();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            Form5 a = new Form5();
            a.Show();
            this.Hide();
        }
    }
}
