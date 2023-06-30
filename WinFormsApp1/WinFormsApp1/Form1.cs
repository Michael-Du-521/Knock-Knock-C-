namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e) {
            if (((Button)sender).Name == "button1")
            {
                label1.Text = "信息: Button1 was Clicked";
            }
            else {
                label1.Text = "信息: Button2 was Clicked";
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}