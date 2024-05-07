namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Əgər   a və b  ədədləri 2 və 4-ə bölünürsə, onların 8-ə də bölünməsini müəyyən etmək üçün proqram tərtib etməli
             */
            Console.WriteLine($"Enter numbers a and b:");
            Console.WriteLine();
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (a % 2 == 0 && a % 4 == 0 && b % 2 == 0 && b % 4 == 0)
            {
                Console.WriteLine($" {a} and {b} are divisible by 2 and 4, and also by 8.");
            }
            else
            {
                Console.WriteLine($"{a} and {b} do not meet the conditions.");
            }
        }
    }
}
