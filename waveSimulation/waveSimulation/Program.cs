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

            /*
                Generating vector field with all vectors set to [0,0]
            */
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());
            Vector[,] matrica = Vector.MatrixGen(n, m);
            int[,] matricab = new int[n, m];
            
            //prints out vector field
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("X:" + matrica[i, j].GetX() + "Y:" + matrica[i, j].GetY());
                    Console.Write(" ");
                }
                Console.WriteLine();
            }

            //Vector vector1 = new Vector(1, 3);
            //Vector vector2 = new Vector(1, 3);
            //Vector vector3 = vector1 + vector2;
            Console.WriteLine("........end........");
        }
    }
}
