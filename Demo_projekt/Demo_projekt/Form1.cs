namespace Demo_projekt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnExample_Click(object sender, EventArgs e)
        {
            
            new FormUkazka().ShowDialog();
        }

        private void BtnKlamta_Click(object sender, EventArgs e)
        {
            
        }
    }
}