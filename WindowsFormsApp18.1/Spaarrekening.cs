using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18._1
{
    class Spaarrekening : Rekening
    {
        private double _percentage;
        public double Percentage
        {
            get => _percentage;
            set => _percentage = value;
        }
        public Spaarrekening()
        {
            Percentage = _percentage;
        }
        public void SchrijfRenteBij()
        {
            if (Saldo == 0)
            {
                MessageBox.Show("Kan geen rente geven op 0. Gelieve een bedrag in te geven. ", "Mededeling. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Saldo *= 1 + Percentage / 100;
        }
        public override string ToString()
        {
            return base.ToString() + $" Percentage {Percentage} ";
        }
    }
}
