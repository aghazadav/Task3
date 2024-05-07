namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                 Verilmiş  a ,b və c tərəflərinə görə üçbucaq qurmağın mümkünlüyünü və həmin üçbucağın bərabəryanlı,
             bərabərtərəfli və ya müxtəliftərəfli olmasını yoxlamalı
             */

            Console.WriteLine($"Enter numbers side a, side b and side c for triangel:");
            Console.WriteLine();
            Console.Write("Side a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Side b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Side c: ");
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a + b > c && c + b > a && a + c > b)
            {
                Console.WriteLine();
                Console.WriteLine($"Creating triangle is possible");
                if (a == b && b == c)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Equilateral triangle created");
                }
                else if (a == b || b == c || c == a)
                {
                    Console.WriteLine();
                    Console.WriteLine($"Isosceles triangle created");
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Scalane triangle created");
                }
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($"Creating triangle not possible");
            }

            
        }
    }
}
