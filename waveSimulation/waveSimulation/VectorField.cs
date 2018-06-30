using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waveSimulation
{
    class VectorField
    {
        public VectorField(int sizex, int sizey)
        {
            this.field = new Vector[sizex, sizey];
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {
                        
                    this.field[i, j] = new Vector(0, 0);

                }
            }
        }
            
        public Vector Funkcija(Vector x)
        {
            return x;
        }
            
        public Vector IzvodX(int posX, int posY, double dx)
        {
            return (this.field[posX + 1, posY] - this.field[posX, posY]) * (1 / dx);
        }

        public Vector IzvodY(int posX, int posY, double dy)
        {
            return (this.field[posX, posY + 1] - this.field[posX, posY]) * (1 / dy);
        }

        public VectorField Pojebi(VectorField main)
        {
            return new VectorField(0,0);
        }

        public Vector this[int x, int y]
        {
            get
            {
                return this.field[x, y];
            }
            set
            {
                this.field[x, y] = value;
            }
        }

        public VectorField Pojebi(int n, int m) { 
            for(int i = 0; i<n; i++)
            {
                for(int j = 0; j<m; j++)
                {
                    poljea[i, j] = polje.IzvodX(i, j, 0.01);
                    poljeb[i, j] = polje.IzvodY(i, j, 0.01);
                }
            }
        return new VectorField()
        }
        private Vector[,] field;

            public double dx = 0.01;
            public double dy = 0.01;
    }
}
