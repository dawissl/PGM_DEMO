using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_projekt
{
    public partial class FormSemenec : Form
    {
        public FormSemenec()
        {
            InitializeComponent();
        }
        public int a;
        public int b;

        private void BtnVypocet_Click(object sender, EventArgs e)
        {
            a = int.Parse(txtbxPocatek.Text);
            b = int.Parse(txtbxKonec.Text);
            if (a > b)
            {
                MessageBox.Show("Neplatný rozsah čísel." + Environment.NewLine + "Počátek musí být nižší jak Konec.");
                return;
            }
            int t = 0;
            for (int i = a; i < b; i++)
            {
                t++;
            }
            MessageBox.Show($"Rozsah je: {t.ToString()}");
            int[] rozsah = new int[t];
            for (int i = 0; i < t;t++)
            {
                rozsah[i] = a + i;
            }
            //MessageBox.Show(rozsah[0].ToString());

        }
    }
}
