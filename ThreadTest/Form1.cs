namespace ThreadTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawGraph()
        {
            int loop = 0;
            int sect = 0;
            float[] x = new float[31];
            float[] y = new float[31];

            while (loop <= 10000)
            {
                sect = (sect + 1) % 25 + 1;
                Graphics g = this.CreateGraphics();
                for (int i = 0; i < sect; i++)
                {
                    x[i] = (float)(150 * Math.Cos(i * 2 * Math.PI / sect) + 150);
                    y[i] = (float)(150 * Math.Sin(i * 2 * Math.PI / sect) + 150);
                }
                for (int m = 0; m < sect - 1; m++)
                {
                    for (int n = 0; n < sect; n++)
                    {
                        g.DrawLine(Pens.Blue, x[m], y[m], x[n], y[n]);
                    }

                }
                Thread.Sleep(200);
                g.Clear(this.BackColor);
                loop++;
            }
        }

        // Define workThread
        Thread DrawGraphThread;


        private void button1_Click(object sender, EventArgs e)
        {
            ThreadStart entryPoint = new ThreadStart(DrawGraph);
            DrawGraphThread = new Thread(entryPoint);
            DrawGraphThread.Start();
            // set the effectiveness of the buttons
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = false;
            button4.Enabled = true;
        }

        [Obsolete]
        private void button2_Click(object sender, EventArgs e)
        {
            DrawGraphThread.Suspend();
            button2.Enabled = (false);
            button3.Enabled = (true);
            button4.Enabled = (false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DrawGraphThread.Resume();
            button2.Enabled = (false);
            button3.Enabled = (true);
            button4.Enabled = (true);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            DrawGraphThread.Abort();
            button1.Enabled = (true);
            button2.Enabled = (false);
            button3.Enabled = (false);
            button4.Enabled = (false);
        }
    }
}