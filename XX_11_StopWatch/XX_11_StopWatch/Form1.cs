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
            //TODO spu�t�n� timeru pro odpo�et �asu
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //TODO pozastaven� timeru pro odpo�et �asu
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Vyresetov�n� stopek na hodnotu 00:00:0
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zv��it �as a zobrazit jej ve form�tu
            // minuty : sekundy : milisekundy
        }
    }
}