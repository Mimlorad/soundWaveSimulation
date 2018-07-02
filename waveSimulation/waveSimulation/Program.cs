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
            VectorField testMatrica = new VectorField(100, 100);

            for(int i = 0; i < 100; i++)
            {
                for(int j = 0; j < 100; j++)
                {
                    double dx = 0.01;
                    double dy = 0.01;
                    testMatrica[i, j] = new Vector(i * dx, i * dy);
                }
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    //double x = Convert.ToDouble(Console.ReadLine());
                    //double y = Convert.ToDouble(Console.ReadLine());
                    polje[i, j] = new Vector(i, j);
                }
            }
            /*
             *  Vrsi izvod po X (ako je X2 onda je to drugi izvod)
             */
            //VectorField izvodPolja = polje.PojebiX(n, m);
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        polje[i, j].SetX(izvodPolja[i, j].GetX());
            //    }
            //}

            /*
             *  Vrsi izvod po Y (ako je Y2 onda je to drugi izvod)
             */

            //izvodPolja = polje.PojebiY(n, m);

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < m; j++)
            //    {
            //        polje[i, j].SetY(izvodPolja[i, j].GetY());
            //    }
            //}
            
            /*
             *  Stampa original matricu
             */

            //Console.WriteLine("posle prvog izvoda");
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
