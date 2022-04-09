using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avaliacao50dias
{
    class Class_CalculosBim
    {
        public double MB1(double notaIG1, double notaIP1, double notaDS1, double notaPAM1, double notaBD1)
        {
            return (notaIG1 + notaIP1 + notaDS1 + notaPAM1 + notaBD1) / 5;
        }

        public double MB2(double notaIG2, double notaIP2, double notaDS2, double notaPAM2, double notaBD2)
        {
            return (notaIG2 + notaIP2 + notaDS2 + notaPAM2 + notaBD2) / 5;
        }

        public double MB3(double notaIG3, double notaIP3, double notaDS3, double notaPAM3, double notaBD3)
        {
            return (notaIG3 + notaIP3 + notaDS3 + notaPAM3 + notaBD3) / 5;
        }

        public double MB4(double notaIG4, double notaIP4, double notaDS4, double notaPAM4, double notaBD4)
        {
            return (notaIG4 + notaIP4 + notaDS4 + notaPAM4 + notaBD4) / 5;
        }

    }
}