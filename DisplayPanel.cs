using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KvadratnaJednadžba;
namespace KvadratnaJednadzba
{
    public partial class DisplayPanel : UserControl
    {
        public event EventHandler CoefficientChanged;
        public readonly QuadraticEquation qe = new QuadraticEquation();
        public DisplayPanel()
        {
            InitializeComponent();

        }

        public void FillResults()
        {
            double a = (double)numericUpDownA.Value;
            double b = (double)numericUpDownB.Value;
            double c = (double)numericUpDownC.Value;

            qe.A = a;
            qe.B = b;
            qe.C = c;

            var roots = qe.Roots;
            textBoxRoot1.Text = roots[0].ToString();
            textBoxRoot2.Text = roots[0].ToString();

            textBoxDiscriminant.Text = qe.Discriminant.ToString();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            FillResults();
            if (CoefficientChanged != null)
                CoefficientChanged(this, EventArgs.Empty);
        }
    }
}
