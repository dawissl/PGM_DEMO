using System.Diagnostics.Eventing.Reader;

namespace XX_11_StopWatch
{// pøejmenujete projekt ve formátu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
        // promìnná držící informaci o ubìhlém èase (výchozí hodnota je 50s)
        double time = 50000;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            TimerWatch.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TimerWatch.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            TimerWatch.Stop();
            TimerWatch.Start();
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            time += 10;
            int ms = ((int)time % 1000) / 10;
            int minuty = (int)time / 60000;
            int sekundy = ((int)time - 60000 * minuty) / 100;

            string stringSeconds = (sekundy < 10) ? $"0{sekundy}" : $"{sekundy}";
            string stringMinutes = (minuty < 10) ? $"0{minuty}" : $"{minuty}";




        }
    }
}