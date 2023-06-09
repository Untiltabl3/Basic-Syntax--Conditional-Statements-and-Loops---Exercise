namespace _08._Triangle_of_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ulong n = ulong.Parse(Console.ReadLine());

            for (ulong i = 1; i <= n; i++) 
            {
                for (ulong j = 1; j <= i; j++) 
                {
                    Console.Write(i+" ");
                }
                Console.WriteLine();
            }
        }
    }
}