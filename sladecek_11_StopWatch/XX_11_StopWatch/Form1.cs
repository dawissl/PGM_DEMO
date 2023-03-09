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
            TimerWatch.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            TimerWatch.Enabled = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            LblWatch.Text = " 00:00:0";
            time = 0;
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zv��it �as a zobrazit jej ve form�tu
            // minuty : sekundy : milisekundy
            time += 10;
            int ms = ((int)time % 1000)/10;
            int minuty = (int) time / 60000;
            int sekundy = ((int)time - 60000 * minuty) / 1000;

            string stringSeconds = (sekundy < 10) ? $"0{sekundy}" : $"{sekundy}";
            string stringMinutes = (minuty < 10) ? $"0{minuty}" : $"{minuty}";



            LblWatch.Text = $"{stringMinutes}:{stringSeconds}:{ms}";
        }
    }
}