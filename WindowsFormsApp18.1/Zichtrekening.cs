using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp18._1
{
    class Zichtrekening : Rekening
    {
        public Zichtrekening(string rekeningnr, double saldo) : base(rekeningnr, saldo)
        {
            Minimum = -100;
        }
    }
}
