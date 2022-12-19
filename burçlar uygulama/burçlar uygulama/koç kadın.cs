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
    public partial class koç_kadın : Form
    {
        public koç_kadın()
        {
            InitializeComponent();
        }

        private void koç_kadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Koç burcu kadını âşık olduğunda dünyanın en çekici kadını gibi görünür. Duygularını tipik bir flört oyunu şeklinde gösterir ve uzun süre bekleyemez. Sevdiği kişiden bir hareket beklerken cinsel cazibesini göstermek için her şeyi yapar.".ToString();
            textBox2.Text = "Koç burcu kadını eğer aşıksa sadakatli biri olur ve her zaman sevdiği kişinin yanındadır. Pek çok durumda Koç burcu kadınının iki kişi için yeteri kadar enerjisi vardır. Lakin eğer aşık değilse ilişkisi son derece gelgitli olur. Özgürlüğüne düşkündür; duygularını çok fazla gösteren birine karşılık veremeyeceğini düşündüğü anda kolayca ilişkiyi bitirir.".ToString();
            textBox3.Text = "Koç burcu kadını sağlıklı bir libidosu ve güçlü düşünceleri olan, samimi ve tutkulu biridir. Yine de inatçı ve sabırsız olabilir. En büyük kusurları, başkalarının kendi işlerini kendileri yapma ihtiyacını anlamamalarıdır. Bu da karışmaması gereken işlere karışmasına yol açabilir.".ToString();
            textBox4.Text = "Koç burcu kadını sade ve açık renkli pratik hediyeleri sever. Giydiği her şey açık ve saldırgan olmayan bir biçimde cinselliklerini sergilemelidir. Mücevher almak iyi bir seçenek olmayabilir; ya çok severler ya da hiç sevmezler. Bununla beraber pahalı ve dikkat çekmeyen bir hediye alırsanız bunu bir yakınlık belirtisi olarak görürler.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 a = new Form3();
            a.Show();
            this.Hide();


        }
    }
}
