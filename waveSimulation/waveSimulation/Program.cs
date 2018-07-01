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
            int m = Convert.ToInt32(Console.ReadLine());
            int n = Convert.ToInt32(Console.ReadLine());
            
            VectorField polje = new VectorField(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    double x = Convert.ToDouble(Console.ReadLine());
                    double y = Convert.ToDouble(Console.ReadLine());
                    polje[i, j] = new Vector(x, y);
                }
            }
            /*
             *  Vrsi izvod po X 
             */
            VectorField izvodPolja = polje.PojebiX2(n, m);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    polje[i, j].SetX(izvodPolja[i, j].GetX());
                }
            }

            /*
             *  Vrsi izvod po Y
             */
            
            izvodPolja = polje.PojebiY2(n, m);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    polje[i, j].SetY(izvodPolja[i, j].GetY());
                }
            }
            
            /*
             *  Stampa original matricu
             */

            Console.WriteLine("posle prvog izvoda");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(polje[i, j].stampanje());
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n........end........");
        }
    }
}
