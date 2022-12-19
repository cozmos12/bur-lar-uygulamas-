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
    public partial class başakkadını : Form
    {
        public başakkadını()
        {
            InitializeComponent();
        }

        private void başakkadını_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Bir Başak kadını size kalbini verdiğinde sonsuza kadar öyle kalmasını ister. Onun için günümüzün sevgililik anlayışı epey zordur; kısa süreli takılmalar, tek gecelik ilişkiler, Başak kadının geleneksel aşk arayışıyla çelişir.".ToString();
            textBox2.Text = "Başak kadını zekâ, detaycılık, sağduyu ve bağlılık karışımı bir şeydir; oldukça zeki, mütevazı ve becerikli olurlar. Kayıtsız gibi göründükleri için Başak kadınını etkilemeye çalışmak ilk başta gözünüzü korkutabilir ama mesafeli olmaktan ziyade, yeni bir ilişkiye başlarken pratik, gerçekçi ve dikkatlidirler.".ToString();
            textBox3.Text = "Başak kadını beyin ve güzelliğin kombinasyonudur. Organizasyon becerileri yüksektir. Laf değil icraat insanıdırlar. Merkür tarafından yönetildikleri için son derece yaratıcı bir mizaca sahiptirler. Öte yandan toprak burcu oldukları için de bir şey yaratırken gerçekten ışıldarlar.".ToString();
            textBox4.Text = "Sağlık ve zindelik Başak kadının en önemli özelliklerindendir; bu nedenle vücut bakımı ve alternatif tıpla ilgili hediyeleri severler. Masaj, akupunktur seansı hediye etmeniz oldukça hoşlarına gidecektir. Ayrıca kitaplar, el yapımı mücevherler ve sanat gereçleri de Başak kadını için şahane hediyelerdir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form8 a = new Form8();
            a.Show();
            this.Hide();


        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
