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
            int[,] matrica = new int[n, m];
            int[,] matricab = new int[n, m];
            
            int t = 0;
            while(t < 1)
            {
                for(int i = 0; i < n; i++)
                {
                    for(int j = 0; j < m; j++)
                    {
                        double x = Convert.ToDouble(Console.ReadLine());
                        double y = Convert.ToDouble(Console.ReadLine());
                        matrica[i, j] = new Vector(x, y);
                        
                    } 
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write("X:" + matrica[i, j].GetX() + "Y:" + matrica[i, j].GetY());
                        Console.Write(" ");
                    }
                    Console.WriteLine();
                }
                t++;
            }
            Console.WriteLine("end");
        }
    }
}
