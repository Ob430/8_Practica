using System;

namespace _8_Practic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine();
            int[,] aj = new int[10, 10];

            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    aj[i, j] = random.Next(100);
                    Console.Write("{0,4}", aj[i, j]);
                }
                Console.WriteLine();
            }






            Console.WriteLine();
            Console.WriteLine("Задание 2");
            Console.WriteLine();
            {
                Console.Write("Размер: (Не больше 10)   ");
                int n = int.Parse(Console.ReadLine());
                int[,] m = new int[n, n];
                int sum;
                Random r = new Random();
                int max;
                int ro = 0, c = 0;
                for (int i = 0; i < n; i++)
                {
                    max = 0;

                    for (int j = 0; j < n; j++)
                    {
                        if (m[i, j] > max) max = m[i, j];

                        m[i, j] = r.Next(100) + 1;
                        if (i == j || i > j)
                            if (m[i, j] > max)
                            {
                                max = m[i, j];
                                ro = i;
                                c = j;
                            }
                        Console.Write("{0,4}", m[i, j]);

                    }
                    Console.WriteLine(" Max: " + max);
                    Console.WriteLine("Координаты: ({0}:{1})", ro, c);
                }


                Console.WriteLine();
                Console.WriteLine("Задание 3");
                Console.WriteLine();
                for (int i = 0; i < n; i++)
                {
                    sum = 0;
                    for (int j = 0; j < n; j++)
                    {
                        sum += m[i, j];
                    }
                    Console.WriteLine("Сумма " + (i + 1) + " столбца равна " + sum);
                }
            }
        }
    }
}
