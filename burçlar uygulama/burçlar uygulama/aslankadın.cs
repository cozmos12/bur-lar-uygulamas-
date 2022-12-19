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
    public partial class aslankadın : Form
    {
        public aslankadın()
        {
            InitializeComponent();
        }

        private void aslankadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Ateş elementine bağlı olan Aslan burcu kadını tutkulu ve cana yakındır; duygularını kolaylıkla ve açık bir biçimde gösterir. Âşık oldukları zaman sevdikleri kişiye karşı eğlenceli, sadık ve oldukça cömert olurlar. Avının peşinde bir aslan kadını dişli bir biridir, avıyla arasına giren herhangi bir şeyi ortadan kaldırmasını bilir.".ToString();
            textBox2.Text = "Hemen hemen tüm ilişkilerinde lider rolünü üstlenirler; bağımsızlık ve inisiyatif alma ihtiyaçlarına sıkı sıkıya tutunurlar. Bu durum partnerlerini zaman zaman yorabilir, bilhassa Aslan burcu kadını kendi isteklerini dayatıp burunlarını sokmamaları gereken işlere burunlarını sokmaya başladıkları zaman can sıkıcıdır. Aslan kadının öz farkındalığı yüksek, makul ve onun kadar zeki biriyle birlikte olması gerekmektedir. Ayrıca bu kişinin kendilerini ifade etme ve kendileri için savaşma gücü yüksek olmalıdır, yoksa Aslan’ın güneşi onları kavurabilir.".ToString();
            textBox3.Text = "Parlak koyu renkler, güçlü saçlar, stiletto ayakkabılar… Çoğu Aslan kadını gücüne vurgu yapan bu tarz şeylerle dikkatleri üzerine çekmeyi sever; hepsi bu kadar iddialı olmasa da çok konuşulacak türden sıra dışı şeyler giymeyi severler.Aslan kadını hakimiyet alanı olan evinin her santimetrekaresini dekore etmeye bayılır. Yaşadığı yerde sadece bir süreliğine de kalsa bunun için zaman harcamayı sever.".ToString();
            textBox4.Text = "Aslan kadını lükse düşkündür; parlak renkli, mücevherli, gösterişli giysileri sever. Ne kadar çok mücevher varsa o kadar iyidir; ister yapay elmas olsun ister Swarovski kristali. Her ne kadar gerçek taşları daha çok sevse de tasarımı özgün ve şatafatlı olan her şeyi sevecektir.".ToString();













        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
            this.Hide();



        }
    }
}
