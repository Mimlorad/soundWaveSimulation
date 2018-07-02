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

        public double X
        {
            get { return x; }
            set { x = value; }
        }


        public double Y
        {
            get { return y; }
            set { y = value; }
        }

        public Vector(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public Vector()
        {
            this.x = 0; this.y = 0;
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
            return new Vector(vec1.X + vec2.X, vec1.Y + vec2.Y);
        }

        public static Vector operator -(Vector vec1, Vector vec2)
        {
            return new Vector(vec1.X - vec2.X, vec1.Y - vec2.Y);
        }

        public static Vector operator*(Vector vec, double scl)
        {
            return new Vector(vec.X * scl, vec.Y * scl);
        }

        public static Vector operator /(Vector vec, double scl)
        {
            return new Vector(vec.X / scl, vec.Y / scl);
        }

        public string stampanje()
        {
            return ("x:" + Convert.ToString(this.X) + ",y:" + Convert.ToString(this.Y) + "  ");
        }
        
    }
}
