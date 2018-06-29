using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waveSimulation
{
    class Vector
    {
        private double x;
        private double y;

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector()
        {
            this.x = 0; this.y = 0;
        }

        public double GetX()
        {
            return this.x;
        }

        public double GetY()
        {
            return this.y;
        }

        public void SetX(double x)
        {
            this.x = x;
        }

        public void SetY(double y)
        {
            this.y = y;
        }
    }

    class Program
    {
        Vector SkalProizvod(Vector vec, double scl)
        {
            return new Vector(vec.GetX()*scl, vec.GetY()*scl);
        }

        double Izvod(double x, double y)
        {
            return 0;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Vector[,] matrica = new Vector[n, m];
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
            Console.WriteLine("........end........");
        }
    }
}
