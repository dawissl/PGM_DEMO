namespace XX_11_StopWatch
{// p�ejmenujete projekt ve form�tu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
        // prom�nn� dr��c� informaci o ub�hl�m �ase (v�choz� hodnota je 50s)
        double time = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //TODO spu�t�n� timeru pro odpo�et �asu
            TimerWatch.Enabled = true;
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //TODO pozastaven� timeru pro odpo�et �asu
            TimerWatch.Stop();
            
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Vyresetov�n� stopek na hodnotu 00:00:0
            LblWatch.Text = "00:00:0";
            time = 0;
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zv��it �as a zobrazit jej ve form�tu
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