using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_projekt
{
    public partial class FormKarras : Form
    {
        public FormKarras()
        {
            InitializeComponent();
        }
        private void Butt_Click(object sender, EventArgs e)
        {
            RTextBoxOUT.Text = "";
            int start = Convert.ToInt32(NumUDStart.Value);
            int end = Convert.ToInt32(NumUDEnd.Value);
            if (NumUDStart.Value <= NumUDEnd.Value)
            {

                for (int i = start; i <= end; i++)
                {
                    int tmp = 0;
                    for (int j = 1; j <= end; j++)
                    {
                        if (i % j == 0)
                        {
                            tmp++;
                        }
                    }
                    if (tmp <= 2)
                    {
                        RTextBoxOUT.Text += i.ToString() + Environment.NewLine;
                    }
                }
            }
        }

    }
}
