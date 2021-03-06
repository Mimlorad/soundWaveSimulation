﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace waveSimulation
{
    class VectorField
    {
        
        public VectorField(VectorField preVectorField)
        {
            
            this.sizex = preVectorField.sizeX;
            this.sizey = preVectorField.sizeY;
            this.field = new Vector[this.sizex, this.sizey];
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {
                    this.field[i, j] = new Vector(preVectorField[i,j].X, preVectorField[i,j].Y);
                }
            }

        }

        public int sizeX
        {
            get { return sizex; }
            set { sizex = value; }
        }

        public int sizeY
        {
            get { return sizey; }
            set { sizey = value; }
        }


        public VectorField(Vector[,] matrica, int sizex, int sizey)
        {
            this.sizex = sizex;
            this.sizey = sizey;
            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {

                    this.field[i, j] = new Vector(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

                }
            }
        }

        public VectorField(int sizex, int sizey)
        {
            this.field = new Vector[sizex, sizey];
            this.sizex = sizex; this.sizey = sizey;

            for (int i = 0; i < sizex; i++)
            {
                for (int j = 0; j < sizey; j++)
                {

                    this.field[i, j] = new Vector(0, 0);

                }
            }
        }

        public Vector IzvodX(int posX, int posY, double dx)
        {
            return (this.field[posX + 1, posY] - this.field[posX, posY]) / dx;
        }

        public Vector IzvodY(int posX, int posY, double dy)
        {
            return (this.field[posX, posY + 1] - this.field[posX, posY]) / dy;
        }

        //public VectorField Pojebiz(VectorField main)
        //{
        //    return new VectorField(0, 0);
        //}

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

        public VectorField PojebiX(int x, int y)
        {
            VectorField rez = new VectorField(x, y);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if(i == x - 1)
                    {
                        rez[i, j] = new Vector(0, 0);
                    }
                    else
                    {
                        rez[i, j] = this.IzvodX(i, j, this.dx);
                    }
                }
            }

            return rez;
        }
        public VectorField PojebiY(int x, int y)
        {
            VectorField rez = new VectorField(x, y);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if(j == y - 1)
                    {
                        rez[i, j] = new Vector(0, 0);
                    }
                    else
                    {
                        rez[i, j] = this.IzvodY(i, j, this.dy);
                    }
                    
                }
            }

            return rez;
        }
        
        public VectorField PojebiX2(int x, int y)
        {
            VectorField rez = this.PojebiX(x, y);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if(i == x - 1)
                    {
                        rez[i, j] = new Vector(0, 0);
                    }
                    else
                    {
                        rez[i, j] = rez.IzvodX(i, j, this.dx);
                    }
                }
            }

            return rez;
        }

        public VectorField PojebiY2(int x, int y)
        {
            VectorField rez = this.PojebiY(x, y);

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if(j == y - 1)
                    {
                        rez[i, j] = new Vector(0, 0);
                    }
                    else
                    {
                        rez[i, j] = rez.IzvodY(i, j, this.dy);
                    }
                }
            }

            return rez;
        }

        public VectorField gradient(int[,] scalarField, int scalarSizeX, int scalarSizeY)
        {
            //foreach u skalarno krljas izvod
            VectorField resultField = new VectorField(scalarSizeX, scalarSizeY);

            for(int x = 0; x < scalarSizeX; ++x)
            {
                for(int y = 0; y < scalarSizeY; ++y)
                {
                    resultField[x, y] = new Vector();
                }
            }
            return new VectorField(0, 0);
        }

        //public VectorField Razjebi(int x, int y)
        //{
        //        
        //}

        //public double[,] skalMatrica(int x, int y)
        //{
        //    return new double[x, y];
        //}

        //public double[,] Divergence()
        //{
        //    return new double[,];
        //}

        private Vector[,] field;

        public double dx = 0.01;
        public double dy = 0.01;
        int sizex;
        int sizey;
    }
}
