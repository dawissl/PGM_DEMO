namespace XX_11_StopWatch
{// p�ejmenujete projekt ve form�tu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
        // prom�nn� dr��c� informaci o ub�hl�m �ase (v�choz� hodnota je 50s)
        double time = 50000;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
           TimerWatch.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TimerWatch.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TimerWatch.Stop();
            time = 0;
            LblWatch.Text = $"M:0 S:0 MS:0";
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zv��it �as a zobrazit jej ve form�tu
            // minuty : sekundy : milisekundy
            time += 10;
            TimeSpan t = TimeSpan.FromMilliseconds(time);

            string s1 = (t.Minutes<10)? $"0{t.Minutes}":$"{t.Minutes}";
            
            
            LblWatch.Text =$"M: {s1} S:{t.Seconds} MS:{t.Milliseconds}";

        }
    }
}