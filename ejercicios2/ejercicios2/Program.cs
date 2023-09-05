using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] answers = { false, false, true };
            List<List<int>> matriz = new List<List<int>>        {



            new List<int> { 11, 2, 4    },
            new List<int> { 4, 5, 6     },
            new List<int> { 10, 8, -12  }

            //new List<int> { 1, 2, 3, 4 },
            //new List<int> { 5, 6, 7, 8 },
            //new List<int> { 9, 10, 11, 12 },
            //new List<int> { 13, 14,15, 16 }


            //  new List<int> { 1, 2, 3, 4,0 },
            //new List<int> { 5, 6, 7, 8,0 },
            //new List<int> { 9, 10, 11, 12,0 },
            //new List<int> { 13, 14,15, 16,0 },
            // new List<int> { 17, 18,19, 20,0 }

            //new List<int> { 1 ,    2 ,    3 ,    4 ,   0,0 },
            //new List<int> { 5 ,    6 ,    7 ,    8 ,   0,0 },
            //new List<int> { 9 ,    10,    11,    12,   0,0 },
            //new List<int> { 13,    14,    15,    16,   0,0 },
            //new List<int> { 17,    18,    19,    20,   0,0 },
            //new List<int> { 17,    18,    19,    20,   0,0 }


            //new List<int> { 1 ,    2 ,    3 ,    4 ,   0,  0,0 },
            //new List<int> { 5 ,    6 ,    7 ,    8 ,   0,  0,0 },
            //new List<int> { 9 ,    10,    11,    12,   0,  0,0 },
            //new List<int> { 13,    14,    15,    16,   0,  0,0 },
            //new List<int> { 17,    18,    19,    20,   0,  0,0 },
            //new List<int> { 17,    18,    19,    20,   0,  0,0 },
            //new List<int> { 17,    18,    19,    20,   0,  0,0 }
        };

            foreach (var fila in matriz)
            {
                foreach (var valor in fila)
                {
                    Console.Write(valor + "\t");
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();

            int resutl = diagonalDifference(matriz);
            Console.WriteLine("resultado " + resutl);
        }


        public static int diagonalDifference(List<List<int>> arr)
        {



            int suma = 0, sumaDiagonalIzquierda = 0, sumaDiagonalDerecha = 0, valorCentral = 0, valoresIntermedios = 0; ;
            for (int i = 0; i < arr.Count; i++)
            {

                for (int j = 0; j < arr.Count; j++)
                {


                    if (i + j == arr.Count - 1)
                    {
                        Console.Write($"{arr[i][j]}" + "\t");
                        sumaDiagonalDerecha += arr[i][j];
                    }
                    if (i == j)
                    {
                        Console.Write($"{arr[i][j]}" + "\t");
                        sumaDiagonalIzquierda += arr[i][j];
                    }





                }
                Console.WriteLine();
                Console.WriteLine();

            }
            Console.WriteLine(sumaDiagonalIzquierda);
            Console.WriteLine(sumaDiagonalDerecha);
            suma = Math.Abs(sumaDiagonalIzquierda - sumaDiagonalDerecha);


            return suma;
        }


    }
}
