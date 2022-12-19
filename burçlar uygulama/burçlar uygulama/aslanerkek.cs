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
    public partial class aslanerkek : Form
    {
        public aslanerkek()
        {
            InitializeComponent();
        }

        private void aslanerkek_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Aslan erkeği romantik ilişkilerinde kral muamelesi görmeyi ister; bu onun narsisist olduğu değil, öz saygısı yüksek bir insan olduğu anlamına gelir. Onunla yapacağınız planlar her zaman büyük ve heyecanlı olacaktır. Aslan erkeği âşık olduğunda çokça hediye verir ve bu hediyelerin çoğu pahalı şeylerdir. Onunla birlikte olmak isteyen herhangi biri kraliyet ailesine girmeyi hak ettiğini kanıtlamalıdır. Aslan erkeği iltifat almayı da sever; her ne kadar özgüvenli görünseler de sevdiklerinin yanındayken güvende hissedebilmek için övülme ihtiyacı duyar.".ToString();
            textBox2.Text = "Bir Aslan erkeğini çileden çıkarmanın birinci yolu onu görmezden gelmektir. Süslü sözler sarf ederek etkileyiciliğini artırmaya çalışır ama bu da en fazla beş dakika sürer. Kısa süre sonra, ölü taklidi yapan fareyle oynamaktan sıkılan kedi gibi ilgisini kaybedecektir. Bu büyük kediyi kendinize çekmek istiyorsanız onun mükemmelliğine hayran olduğunuzu gösterin ve bol bol iltifat edin.".ToString();
            textBox3.Text = "Aslan erkeği bulunduğu her yerde ilgi odağı olmayı sever. Enerjik, neşeli ve biraz çocuksu olan Aslan erkekleri hayatta olduklarını hissetmeyi severler ve coşkularını birlikte zaman geçirdikleri insanlarla paylaşmanın bir yolunu bulurlar. Canlı ve büyüleyici kişilikleri son derece çekicidir.".ToString();
            textBox4.Text = "Epey gurme olan Aslan erkekleri, pişirmeyi sevmeseler de iyi yemek yemeyi severler. Pek çok kişi tarafından beğenilen güzel bir restoranda iyi bir akşam yemeği güzel bir seçenek olabilir; tabii daha önce binlerce kez gitmediği bir yerse. Aslan erkekleri sıra dışı olmayı tercih ettikleri için dünya mutfağından farklı yemekler yapan bir restorana götürebilirsiniz.Aslan erkekleri gösterişçi ve kurumludurlar, dışarıdan nasıl göründüklerine önem verirler. Bu yüzden saç bakım ürünleri, tıraş ürünleri de güzel bir seçenek olabilir.".ToString();











        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
            this.Hide();

        }
    }
}
