namespace ColorGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBxAns.Text))
            {
                List<Color> list = new List<Color> {
                Color.Ivory,
                Color.Pink,
                Color.PowderBlue,
                Color.Yellow,
                Color.LightGreen };

                Random rndm = new Random();

                bool isMatched = false;

                foreach (PictureBox pb in this.Controls.OfType<PictureBox>())
                {
                    int roll = rndm.Next(list.Count);
                    pb.BackColor = list[roll];

                    switch (txtBxAns.Text.ToLower())
                    {
                        case "pink":
                            if (pb.BackColor == Color.Pink)
                            {
                                isMatched = true;
                            }
                            break;
                        case "white":
                            if (pb.BackColor == Color.Ivory)
                            {
                                isMatched = true;
                            }
                            break;
                        case "green":
                            if (pb.BackColor == Color.LightGreen)
                            {
                                isMatched = true;
                            }
                            break;
                        case "yellow":
                            if(pb.BackColor == Color.Yellow)
                            {
                                isMatched= true;
                            }
                            break;
                        case "blue":
                            if (pb.BackColor == Color.PowderBlue)
                            {
                                isMatched = true;
                            }
                            break;
                        default:
                            break;
                    }
                }
                if (isMatched)
                {
                    label1.Text = $"You got a {txtBxAns.Text}! Claim your prize!";
                }
                else
                {
                    label1.Text = "You did not find any match. Try again";
                }
            }
            else
            {
                label1.Text = "Provide a bet first";
            }
        }

        private void txtBxAns_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
    }
}
