using System.Diagnostics;


namespace XX_11_StopWatch
{// p�ejmenujete projekt ve form�tu jmeno_11_StopWatch
    public partial class Form1 : Form
    {
       
      
         private Stopwatch stopWatch;
        // prom�nn� dr��c� informaci o ub�hl�m �ase (v�choz� hodnota je 50s)
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnStart_Click(object sender, EventArgs e)
        {
            //TODO spu�t�n� timeru pro odpo�et �asu
            stopWatch.Start();
        }

        private void BtnStop_Click(object sender, EventArgs e)
        {
            //TODO pozastaven� timeru pro odpo�et �asu
            stopWatch.Stop();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            // Vyresetov�n� stopek na hodnotu 00:00:0
            stopWatch.Reset();
        }

        private void TimerWatch_Tick(object sender, EventArgs e)
        {
            // TODO  zv��it �as a zobrazit jej ve form�tu
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