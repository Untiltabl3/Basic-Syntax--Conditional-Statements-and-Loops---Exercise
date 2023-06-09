namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int biggerDivison = 0;

            if (number % 2 == 0)
            {
                biggerDivison = 2;
            }
            if (number % 3 == 0)
            {
                biggerDivison = 3;
            }
            if (number % 6 == 0)
            {
                biggerDivison = 6;
            }
            if (number % 7 == 0)
            {
                biggerDivison = 7;
            }
            if (number % 10 == 0)
            {
                biggerDivison = 10;
            }

            if (biggerDivison == 0)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {biggerDivison}");
            }
        }
    }
}