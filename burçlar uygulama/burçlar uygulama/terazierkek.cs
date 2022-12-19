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
    public partial class terazierkek : Form
    {
        public terazierkek()
        {
            InitializeComponent();
        }

        private void terazierkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Terazi burcu erkekleri acı gerçeklerdense şiirsel bir ideali tercih eden umutsuz romantiklerdir. Partnerleri açısından Terazi erkeklerinin yüksek kaidelerine uyum sağlamak zor olabilir. Gerçek hayatın keskin kenarları bu burcun erkekleri için tatsızdır. Her daim yanlış bir karar vermekten ve uzun süreli bir ilişkiye girmekten korkan Terazi erkekleri hakkında bir karar vermek yanıltıcı olabilir.".ToString();
            textBox2.Text = "Terazi burcu erkeği yalnız olmaktan nefret eder ve kendisiyle, duygularıyla yüzleşmekten korkar. Bu nedenle birden fazla partnerle kendisini oyalar. Uzun süreli ilişkide ise Terazi erkeği hayallerinizin erkeği olabilir: Sizi iltifatlar ve jestlerle şımartır. Kendi içindeki özgürlük – bağlılık çelişkisini bir çözüme bağlayabilirse güzel bir ilişki ortaya çıkabilir.".ToString();
            textBox3.Text = "Terazi burcu erkeği gerçek bir ehlikeyiftir; daldan dala konar, karmaşa yaratır, sonra da bir anda ortadan kaybolur. Dürüstlük, birlik ve güzellik gibi ütopik idealler üzerinde şiirler yazmayı sever.".ToString();
            textBox4.Text = "Terazi burcu erkekleri Zodyak’ın züppeleridir. Son modaya uygun giyinmeyi severler ve pek çok erkeğin giyemeyeceği türden şeyler giyerler. Şapkalar ve şallar, dikkat çekici gözlükler en sevdiği aksesuarlar arasındadır; dolayısıyla bu tarz bir hediye hoşlarına gidecektir. Modaya düşkün olan Terazi burcu erkekleri için önemli olan kalite değil yeniliktir. Hediye seçiminde buna dikkat ederseniz çok seveceği bir hediye alabilirsiniz.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 a = new Form9();
            a.Show();
            this.Hide();


        }
    }
}
