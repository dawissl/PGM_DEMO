namespace XX_11_StopWatch
{// pøejmenujete projekt ve formátu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
        // promìnná drící informaci o ubìhlém èase (vıchozí hodnota je 50s)
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

        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zvıšit èas a zobrazit jej ve formátu
            // minuty : sekundy : milisekundy
             time += 10;
            int mil = 00;
            int sec = 00;
            int min = 00;
            LblWatch.Text = $"{min}:{sec}:{mil}";

            if (time > 100 )
            {
                int sec += 1;
            }
                
                
                 
            
          
        }
    }
}