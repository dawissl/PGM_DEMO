namespace XX_11_StopWatch
{// pøejmenujete projekt ve formátu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
        // promìnná držící informaci o ubìhlém èase (výchozí hodnota je 50s)
        double time = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //TODO spuštìní timeru pro odpoèet èasu
            TimerWatch.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //TODO pozastavení timeru pro odpoèet èasu
            TimerWatch.Stop();
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Vyresetování stopek na hodnotu 00:00:0
            LblWatch.Text = "00:00:0";
            time = 0;
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zvýšit èas a zobrazit jej ve formátu
            // minuty : sekundy : milisekundy
             time += 10;
            int mil = ((int)time % 1000)/10;
            int sec = (int) time /60000;
            int min = ((int)time - 60000 * min)/ 1000;

            string stringSeconds = (sec < 10) ? $"0{sec}" : $"{sec}";
            string stringMinutes = (min < 10) ? $"0{min}" : $"{min}";





        }
    }
}