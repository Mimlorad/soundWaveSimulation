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
                        matrica[i,j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        Console.Write(matrica[i, j]);
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
