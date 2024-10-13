using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace varijable
    internal class Program
{

    static void Main()
    {
        double a = 2.0;
        double b = 3.0;
        double c = 4.0;
        double d = 5.0;

        double x = (Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2) + Math.Pow(d, 2)) /
                   (Math.Pow(a + b, 2) + Math.Pow(c + d, 2));

        Console.WriteLine("Vrijednost x je: " + x);
    }

}
