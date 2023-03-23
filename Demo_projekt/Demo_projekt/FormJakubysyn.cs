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
    public partial class FormJakubysyn : Form
    {
        public FormJakubysyn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         bool aa=   int.TryParse(txt_jedna.Text, out int a);
          bool bb=  int.TryParse(txt_dva.Text, out int b);
            if(!aa || !bb)
            {
                MessageBox.Show("Není číslo");
                return;
                    
            }
                

            if (a >= b)
                return;

            for (int i= a; i <=b ; i++)
            {
                if (IsPrime(i))
                    listBox1.Items.Add(i);


            }



        }
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i < number; i=+2)
                if (number % i == 0)
                   return true;
                    return false;
                
            
           
        }
    }
}
