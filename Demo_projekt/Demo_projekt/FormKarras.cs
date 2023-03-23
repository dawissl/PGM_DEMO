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
            int start = Convert.ToInt32(NumUDStart);
            if (NumUDStart.Value < NumUDend.Value)
            {
                int tmp = 1;
                while (start != NumUDend.Value)
                {
                    
                    if (start % tmp == 0 && tmp != 1 || tmp != start)
                    {
                        LblOUT.Text += $"\n{start}";
                    }
                    start++;
                }


            }
        }
    }
}
