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
    public partial class kovakadın : Form
    {
        public kovakadın()
        {
            InitializeComponent();
        }

        private void kovakadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Kova kadınlarının soğuk bir cazibesi vardır; tıpkı uzaktaki bir yıldızın soğuk ve cılız parıltısı gibi. Yanınızda otururken bile ruhları sizden binlerce ışık yılı uzaklıkta olabilir. Sıcakkanlı, duygusal sevgililer olamaz değillerdir. Ama gerçekten âşık oldukları şey zihinsel bir ilişkidir; önemli olan şu anda ilişkilerinde ne hissettikleri değil, gelecekteki planlarıdır.".ToString();
            textBox2.Text = "Kova kadınlarının ilişkilerinde kişisel alana sahip olmaları, kendi hayatıyla ilgili kararları kendilerinin verebiliyor olmaları önemlidir. Son derece bağımsız olan Kova kadınları uzun süre boyunca aynı yere çakılı kalmaktan hoşlanmazlar. Bu burcun kadınları için iletişim önemlidir. Ayrıca çoğu Kova kadını kendini “sapyoseksüel” olarak görür, dolayısıyla güçlü bir zekayı çekici bulurlar.".ToString();
            textBox3.Text = "Kova kadını herhangi bir toplumsal standarda uymaz. Sınırlarda yaşamayı sever ve her zaman çizgi dışı düşünür. Toplumsal adalet ve toplumsal değişim gibi konulara ilgi duyan Kova kadınları yoksulluk, dünya sağlığı, eşit haklar gibi konulara katkıda bulunmayı ister: Bu nedenle bir Kova kadınını protestolarda, imza kampanyalarında, mitinglerde vs. görmeniz olasıdır.".ToString();
            textBox4.Text = "Kova kadınları, aldığınız hediye daha önce görmedikleri bir şey olduğu müddetçe ne alırsanız alın beğenir. Hemen hemen her şehirde bulunan bir zincir mağazadan hediye kartı vermek, ona önemsenmiyormuş gibi hissettirebilir. Dolayısıyla Kova kadınına tıpkı onun gibi benzersiz ve sıra dışı bir şey almanız gerekmektedir. Nadir bulunan kristaller ya da taşlar güzel bir seçenek olabilir.".ToString();











        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form13 a = new Form13();
            a.Show();
            this.Hide();
        }
    }
}
