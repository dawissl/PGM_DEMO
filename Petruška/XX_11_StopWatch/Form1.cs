namespace XX_11_StopWatch
{// p�ejmenujete projekt ve form�tu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
        // prom�nn� dr��c� informaci o ub�hl�m �ase (v�choz� hodnota je 50s)
        double time = 0;
        int ms = 0;
        int s = 0;
        int min = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            //TODO spu�t�n� timeru pro odpo�et �asu
            TimerWatch.Start();
          
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //TODO pozastaven� timeru pro odpo�et �asu
            TimerWatch.Stop();  
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Vyresetov�n� stopek na hodnotu 00:00:0

        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zv��it �as a zobrazit jej ve form�tu
            // minuty : sekundy : milisekundy
            time += 10;

            if (time > 10)
            {
                ms = (int)time / 10;

            }
            if (ms == 9)
            {
                s++;
                ms = 0;
            }
            if (s == 60)
            {
                min++;
                s = 0;
            }

            LblWatch.Text = (min, ":",s,":",ms).ToString();
            
        }

        private void LblWatch_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }
    }
}