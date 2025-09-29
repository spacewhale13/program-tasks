using System;
class Solution
{

    static void Main(string[] args)

    {
        //1 задача
        Console.WriteLine("Введите число: ");

        void Solve(int num)
        {

            Console.WriteLine($"{Math.Pow(num, 2)}");

        }
        Solve(int.Parse(Console.ReadLine()));

        for (int i = 10; i > 0; i--)
        {
            Console.WriteLine(i);

        }
        Console.WriteLine("Введите число: ");
        void Solve_new(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("Положительное");
            }
            else if (num < 0)
            {
                Console.WriteLine("Отрицательное");

            }
            else
            {
                Console.WriteLine("Число равно 0");
            }
        }
        Solve_new(int.Parse(Console.ReadLine()));
    }

    

    static void Main(string[] args) {
        Console.WriteLine("Введите число");
        void Solve(int A, int B)
        {
            
            if (A < B)
            {
                int res = 0;
                for (int i = A; i <= B; i++)
                {
                    res += i;
                    
                }
                Console.WriteLine(res);

                /*for (int i = num; i > 0; i--)
                {
                    res *= i;

                }*/
                
            }
            else {
                Console.WriteLine("Ошибочный интервал");
                
            }

        }
        Solve(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
    }
    
    

}

