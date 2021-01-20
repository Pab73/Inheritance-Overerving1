using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp18._1
{
    class Rekening
    {
        private double _minimum;
        private string _rekeningnr;
        private double _saldo;

        public double Minimum
        {
            get => _minimum;
            set => _minimum = value;
        }
        public String Rekeningnr
        {
            get => _rekeningnr;
            set => _rekeningnr = value;
        }
        public double Saldo
        {
            get => _saldo;
            set => _saldo = value;
        }
        public Rekening()
        {
            Minimum = _minimum;
            Rekeningnr = _rekeningnr;
            Saldo = _saldo;
        }
        public Rekening(string rekeningnr, double saldo)
        {
            Minimum = 0;
            Rekeningnr = rekeningnr;
            Saldo = saldo;
        }
        public void Storten(double bedrag)
        {
            if (bedrag < 0)
            {
                MessageBox.Show("Het bedrag moet positief zijn. ", "Mededeling. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                _saldo += bedrag;
            }
        }
        public void Afhalen(double bedrag)
        {
            if (bedrag < 0)
            {
                MessageBox.Show("Het bedrag moet positief zijn. ", "Mededeling. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (_saldo - bedrag < _minimum)
                {
                    MessageBox.Show("Het saldo mag niet onder het minimum komen. ", "Mededeling. ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    _saldo -= bedrag;
                }
            }
        }
        public override string ToString()
        {
            return $"  Rekeningnummer {Rekeningnr} met saldo {Saldo:0.00} ";
        }
    }
}
