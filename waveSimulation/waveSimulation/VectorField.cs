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
                Vector rez = (this.field[posX + 1, posY] - this.field[posX, posY]) * (1 / dx);
                return rez;
            }

            public Vector IzvodY(int posX, int posY, double dy)
            {
                Vector rez = ( this.field[posX, posY + 1] - this.field[posX, posY]) * (1 / dy);
                return rez;
            }

            public VectorField Pojebi(VectorField main)
            {
                
            } 

            private Vector[,] field;

            public double dx = 0.01;
            public double dy = 0.01;
        }
}
