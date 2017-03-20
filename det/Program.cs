using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace det
{
    class Program
    {
        public void Main(string[] args)
        {
            Console.WriteLine(" Значення має бути більше 1");
            Console.Write("Введіть розмірність матриці: ");
            uint k = Convert.ToUInt32(Console.ReadLine());
            if (k <= 0)
            {
                Console.Write(" Значення має бути більше 0 ");

            }
            else
            {
                Random r = new Random();
                double[,] tabl;
                tabl = new double[k, k];
                for (int i = 0; i < k; i++)
                {
                    for (int j = 0; j < k; j++)
                    {
                        tabl[i, j] = r.Next(0, 10);
                        Console.Write(tabl[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("det = " + Determinant(tabl));
            }
            Console.WriteLine();
            Console.ReadKey();
        }

        public int SignOfElement(int i, int j)
        {
            if ((i + j) % 2 == 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        public double[,] CreateSmallerMatrix(double[,] input, int i, int j)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            double[,] output = new double[order - 1, order - 1];
            int x = 0, y = 0;
            for (int m = 0; m < order; m++, x++)
            {
                if (m != i)
                {
                    y = 0;
                    for (int n = 0; n < order; n++)
                    {
                        if (n != j)
                        {
                            output[x, y] = input[m, n];
                            y++;
                        }
                    }
                }
                else
                {
                    x--;
                }
            }
            return output;
        }
        public double Determinant(double[,] input)
        {
            int order = int.Parse(System.Math.Sqrt(input.Length).ToString());
            if (order > 2)
            {
                double value = 0;
                for (int j = 0; j < order; j++)
                {
                    double[,] Temp = CreateSmallerMatrix(input, 0, j);
                    value = value + input[0, j] * (SignOfElement(0, j) * Determinant(Temp));
                }
                return value;
            }
            else if (order == 2)
            {
                return ((input[0, 0] * input[1, 1]) - (input[1, 0] * input[0, 1]));
            }
            else
            {
                return (input[0, 0]);
            }

        }
    }
}

