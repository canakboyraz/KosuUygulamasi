using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPKosuUygulamasi.Abstract
{
    internal interface IMesafe
    {
        double TemposuzKosu(int süre);
        double ToplamAdım(int dakika, int adım);
        double TempoluKosu(int dakika, int adım);

        double ToplamYol(double temposuzKosu, double tempoluKosu);
    }
}
