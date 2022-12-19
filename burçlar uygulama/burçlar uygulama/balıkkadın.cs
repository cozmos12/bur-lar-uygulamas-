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
    public partial class balıkkadın : Form
    {
        public balıkkadın()
        {
            InitializeComponent();
        }

        private void balıkkadın_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Aşka âşık olurlar, karşılarındaki kişi genelde teferruat gibidir; tabii bu yaşamlarının ilk zamanlarında olur. Tecrübe sahibi oldukça, dinginleşir, olgunlaşırlar. Karşısındakileri şefkatleriyle şımartabilirler fakat onların şımartabilmesi şımarmanız anlamına gelmesin, garip hareketlerle onları üzerseniz bir süre sonra yürekleri daralır ve tek kuyruk darbesiyle sizi terk ederler; aniden hayatınızdan çıkıverirler. Sevgilileriyle dost olmayı çok severler. Ayrıca Balık burcu kadınları psikolojik ya da duygusal sorunları olan partnerlere kapılmalarıyla meşhurdur.".ToString();
            textBox2.Text = "Kişisel ilişkilerinde özverilidirler fakat zaman zaman inzivaya çekilip kendilerini yenilemeleri gerekir. Bu yenilenme hem onlara hem de sevdiklerine iyi gelecektir. Karşısındaki kişiden gelen güzel şeyleri almayı da öğrenmesi gereken bu özverili, cömert kadınlar için karşılıklılık alengirli bir şeydir. Bir su burcu olarak, kendine zaman ayırmadan başkasına kalbinin içindeki her şeyi dökmeye eğilimlidir.".ToString();
            textBox3.Text = "Balık burcunun kendi kendilerini ve etrafı iyileştirebilme güçleri vardır. Empatların azımsanmayacak bir kısmı bu burçtan çıkar. Güçlü yanlarının görünürlüğe kavuşabilmesi ve güçlenebilmesi için Balık kadınının kendi kendini küçümseyerek göz ardı etmek yerine, kendini keşfetmesi gerekir. Karşılarındaki kimseyi, olayı kolaylıkla okuyup çözebilirler. Ağlamak onlar için çok olağan bir eylemdir, bu yüzden de adları sulu göze çıkmıştır. Balık burcu konuşmak yerine sizi dinlemeyi tercih eder. Biraz ketumdurlar, kendi dertlerinden çok söz etmezler ama sizi dinlerler ve konuşamadıkları için de sık sık ağlarlar.".ToString();
            textBox4.Text = "Balık kadınları, yanına kendi yazdığınız bir şiiri iliştirdiğiniz bir demet çiçek gibi romantik hediyelere bayılırlar. Güzel olan her şeyi beğenirler. El üfleme cam prespapyeler, mücevher tonlarında vazolar, heykeller, rüzgâr çanları kalplerini fethedecektir. Ayrıca kendi sanat eserlerini yaratabilecekleri kaliteli sanat malzemeleri de güzel bir seçenek olabilir.".ToString();





        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form14 a = new Form14();
            a.Show();
            this.Hide();
        }
    }
}
