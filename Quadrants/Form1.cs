namespace Quadrants
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startnumber = 0;
        int endnumber = 0;
        int numbertowrite = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int.TryParse(textBox1.Text, out startnumber);
            int.TryParse(textBox2.Text, out endnumber);  

            richTextBox1.Text = (startnumber * startnumber).ToString();
            numbertowrite = startnumber + 1;

            while (numbertowrite <= endnumber)
            {
                richTextBox1.Text += " ";
                richTextBox1.Text += (numbertowrite * numbertowrite).ToString();
                numbertowrite++;
            }
        }
    }
}
