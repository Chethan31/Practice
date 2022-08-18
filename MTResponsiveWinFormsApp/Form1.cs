namespace MTResponsiveWinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Parallel.Invoke(InitializeComponent);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new Thread(() =>
            //{
            //Draw red rectangle
            //Graphics g = panel1.CreateGraphics();
            //Random random = new Random();
            //for (int i = 0; i < 1000; i++)
            //{
            //    int x = random.Next(panel1.Height);
            //    int y = random.Next(panel1.Width);
            //    g.DrawRectangle(Pens.Red, x, y, 20, 20);
            //    Thread.Sleep(100);
            //}
            //}).Start();
            Thread t1 = new Thread(DrawRedRectangle);
            t1.Start();
        }

        private void DrawRedRectangle()
        {
            Graphics g = panel1.CreateGraphics();
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int x = random.Next(panel1.Height);
                int y = random.Next(panel1.Width);
                g.DrawRectangle(Pens.Red, x, y, 20, 20);
                Thread.Sleep(100);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new Task(() =>
            //{
            //    Graphics g = panel2.CreateGraphics();
            //    Random random = new Random();
            //    for (int i = 0; i < 1000; i++)
            //    {
            //        int x = random.Next(panel2.Height);
            //        int y = random.Next(panel2.Width);
            //        g.DrawRectangle(Pens.Blue, x, y, 20, 20);
            //        Thread.Sleep(100);
            //    }
            //}).Start();
            Task t2 = new Task(DrawBlueRectangle);
            t2.Start();
        }
        private void DrawBlueRectangle()
        {
            Graphics g = panel2.CreateGraphics();
            Random random = new Random();
            for (int i = 0; i < 1000; i++)
            {
                int x = random.Next(panel2.Height);
                int y = random.Next(panel2.Width);
                g.DrawRectangle(Pens.Blue, x, y, 20, 20);
                Thread.Sleep(100);
            }

        }
    }
}