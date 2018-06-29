using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waveSimulation
{
    public class Vector
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

        double Izvod(double x, double y)
        {

            return 0;
        }
        public static Vector[,] MatrixGen(int sizex, int sizey)
        {
            Vector[,] rez = new Vector[sizex, sizey];
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {

                    rez[i, j] = new Vector(0, 0);

                }
            }
            return rez;
        }

        public static Vector operator +(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.GetX() + vec2.GetX(), vec1.GetY() + vec2.GetY());
        }

        public static Vector operator -(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.GetX() - vec2.GetX(), vec1.GetY() - vec2.GetY());
        }

        public static Vector operator*(Vector vec, double scl)
        {
            return new Vector(vec.GetX() * scl, vec.GetY() * scl);
        }

        
    }
}
