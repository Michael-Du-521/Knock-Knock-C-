using System.Text.RegularExpressions;

namespace RegularExpressionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string expression =@"SN\w\w-\d\d\d\d-[abc]{4}-[@#]{4}";
            if (Regex.IsMatch(textBox1.Text, expression))
            {
                MessageBox.Show("Register successfully");
            }
            else
            {
                MessageBox.Show("Wrong SerialNo£¬Please try again");
            }

        }
    }
}