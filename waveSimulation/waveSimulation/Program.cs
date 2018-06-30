using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waveSimulation
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            
            VectorField polje = new VectorField(n, m);
            VectorField izvodPolja = polje.PojebiX(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    polje[i, j].SetX(izvodPolja[i, j].GetX());
                }
            }

            izvodPolja = polje.PojebiY(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    polje[i, j].SetY(izvodPolja[i, j].GetY());
                }
            }

            Console.WriteLine("\n........end........");
        }
    }
}
