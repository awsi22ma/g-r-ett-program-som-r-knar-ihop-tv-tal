using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gör_ett_program_som_räknar_ihop_två_tal
{
    public partial class Form1 : Form

    {
        double Tal1, Tal2, Summa;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnKör_Click_1(object sender, EventArgs e)
        {
            Tal1 = Convert.ToDouble(tbxTal1.Text);
            Tal2 = Convert.ToDouble(tbxTal2.Text);
            Summa = Tal1 + Tal2;
            lblSumma.Text = Summa.ToString();
        }

       


       

    }
    
}
