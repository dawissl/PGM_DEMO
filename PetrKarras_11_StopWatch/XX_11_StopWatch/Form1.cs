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
            //TODO spuštìní timeru pro odpoèet èasu
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //TODO pozastavení timeru pro odpoèet èasu
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Vyresetování stopek na hodnotu 00:00:0
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zvýšit èas a zobrazit jej ve formátu
            // minuty : sekundy : milisekundy
        }
    }
}