using System;

namespace tpzslaba9_1_
{
    class Program
    {
        static void MethodAct(int[,] arr, Action<int> act)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    act(arr[i, j]);
                }
            }
        }

        static void MethodFunc(int[,] arr, Func<int, int> act)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = act(arr[i, j]);
                }
            }
        }

        static void Show(int num)
        {
            Console.Write(num + "\t");
        }

        static void ShowPositive(int num)
        {
            if (num > 0)
                Console.Write(num + "\t");
        }

        static int Mult3(int num)
        {
            if (num > 0)
                return num * 3;
            else
                return num;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите размерность матрицы: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[n, n];

            Random rand = new Random();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                }
            }

            Console.WriteLine("Наша матрица:");
            MethodAct(arr, Show);
            Console.WriteLine();

            Console.WriteLine("Положительные элементы матрицы:");
            MethodAct(arr, ShowPositive);
            Console.WriteLine();

            Console.WriteLine("Положительные элементы матрицы, умноженные на 3:");
            MethodFunc(arr, Mult3);
            MethodAct(arr, ShowPositive);
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}
