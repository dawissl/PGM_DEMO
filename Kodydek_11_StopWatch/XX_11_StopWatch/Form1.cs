using System.Diagnostics;


namespace XX_11_StopWatch
{// pøejmenujete projekt ve formátu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
       
      
         private Stopwatch stopWatch;
        // promìnná držící informaci o ubìhlém èase (výchozí hodnota je 50s)
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //TODO spuštìní timeru pro odpoèet èasu
            stopWatch.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //TODO pozastavení timeru pro odpoèet èasu
            stopWatch.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Vyresetování stopek na hodnotu 00:00:0
            stopWatch.Reset();
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zvýšit èas a zobrazit jej ve formátu
            // minuty : sekundy : milisekundy
            this.LblWatch.Text = stopWatch.Elapsed.ToString(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stopWatch = new Stopwatch();
           
        }

        private void LblWatch_Click(object sender, EventArgs e)
        {

        }
    }
}