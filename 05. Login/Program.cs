using System;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();


            string password = string.Empty;

            for (int i = username.Length - 1; i > -1; i--)
            {
                password += username[i];
            }

            string attempt ;

            int counter = 0;

            while ((attempt = Console.ReadLine()) != password)
            {
                if (counter == 3)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                Console.WriteLine("Incorrect password. Try again.");
                counter++;
            }

            if (password == attempt)
            Console.WriteLine($"User {username} logged in.");


        }
    }
}