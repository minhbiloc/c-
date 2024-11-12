using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonAn
{
    internal class SoPhuc
    {
        private double PhanThuc;
        private double PhanAo;
        public SoPhuc(double phanThuc, double phanAo)
        {
            PhanThuc = phanThuc;
            PhanAo = phanAo;
        }

        public override string ToString()
        {
            return $"{PhanThuc} + {PhanAo}i";
        }
    }
    }
