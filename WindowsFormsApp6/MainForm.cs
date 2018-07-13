using System.Windows.Forms;

using Card_Info.Core;
using WindowsFormsApp6.Core;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {

        private static CardsImage cardsImage = null;

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            cardsImage = new CardsImage();
            sourceImage.Image = cardsImage.GetSource();

            if (cardsImage.IsFind() != false)
            {
                templateImage.Image = cardsImage.GetTemplate();
                textImage.Image = cardsImage.FindTextBitmap();
                CardNameLabel.Text = cardsImage.FindCardName();
                positionLabel.Text = "Position " + cardsImage.FindPosition().ToString();
            }
            else
            {
                MessageBox.Show("Cannot find card");
            }
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {

        }
    }
}
