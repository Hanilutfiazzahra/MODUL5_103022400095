using System;
using System.Collections.Generic;
using System.Text;

namespace MODUL5_103022400095
{
    internal class PemrosesanData
    {
        public void DapatkanNilaiTerpesar<T> (T a, T b, T c) 
        {
            dynamic maks;
            dynamic temp1 = a;
            dynamic temp2 = b;
            dynamic temp3 = c;

            if (temp1 > temp2 && temp1 > temp2)
            {
                maks = a;
            }
            else if (temp2 > temp1 && temp2 > temp3)
            {
                maks = b;
            }
            else
            {
                maks = c;
            }

            Console.WriteLine("Nilai terbesar adalah: " + maks);

        }
    }
}
