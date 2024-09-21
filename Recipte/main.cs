using System.Diagnostics;
using System.Xml.Serialization;

namespace Recipte
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var pizaaform = new Пицца();
            pizaaform.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var cheese_sticksForm = new Cheese_sticks();
            cheese_sticksForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var Espagets_CarbonaraForm = new Карбонара();
            Espagets_CarbonaraForm.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var PotatoForm = new Potato();
            PotatoForm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var PotatoVillageForm = new Potato_village();
            PotatoVillageForm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var EggsConvertsForm = new Eggs_converts();
            EggsConvertsForm.Show();
        }
    }
}
