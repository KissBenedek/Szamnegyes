using System;
using System.Security.Cryptography.X509Certificates;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] result = TableGame([[1, 2, 1], [2, 4, 2], [1, 2, 1]]);

            string stringResult = string.Join(", ", result);
            Console.WriteLine("[ " + stringResult + " ]");
        }
        static int[] TableGame(int[][] tabla)
        {
            for (int i = 0; i < 3; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    if (tabla[0][0] + tabla[0][2] != tabla[0][1])
                    {
                        return [-1];
                    }
                    if (tabla[0][0] + tabla[2][0] != tabla[1][0])
                    {
                        return [-1];
                    }
                    if (tabla[2][0] + tabla[2][2] != tabla[2][1])
                    {
                        return [-1];
                    }
                    if (tabla[0][2] + tabla[2][2] != tabla[1][2])
                    {
                        return [-1];
                    }
                    if (tabla[0][0] + tabla[0][2] + tabla[2][0] + tabla[2][2] != tabla[1][1])
                    {
                        return [-1];
                    }
                }
            }
            return new int[] { tabla[0][0], tabla[0][2], tabla[2][0], tabla[2][2] };
        }
    }
}