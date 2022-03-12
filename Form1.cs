namespace ScammerScoreboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (!backgroundWorker1.IsBusy)
            backgroundWorker1.RunWorkerAsync();
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        public static int score = 0;
        public static int old_score = 0;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            score += 5;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            score += 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            score += 7;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            score += 6;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            score += 10;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            score += 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            score += 5;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            score += 5;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            score += 5;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            score += 14;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            score += 5;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            score += 12;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            score += 5;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            score += 25;
        }

        private void backgroundWorker1_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            while (true)
            {
                if (old_score != score)
                backgroundWorker1.ReportProgress(score);
                Thread.Sleep(100);
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            label2.Text = score.ToString();
            // max score is 117
            if (score >= 117)
            {
                score = 0;
                label2.Text = "A++";
            }
            old_score = score;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            score = 0;
            label2.Text = "0";
        }
    }
}