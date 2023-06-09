using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleNum = int.Parse(Console.ReadLine());

            string typePeople = Console.ReadLine();

            string dayType = Console.ReadLine();

            double sum = 0;

            if (typePeople == "Students")
            {
                if (dayType == "Friday") //Friday 8.45
                {
                    sum = peopleNum * 8.45;
                }
                else if (dayType == "Saturday")//Saturday  9.80 
                {
                    sum = peopleNum * 9.80;
                }
                else if (dayType == "Sunday") //Sunday  10.46 
                {
                    sum = peopleNum * 10.46;
                }

                if (peopleNum >= 30)
                {
                    sum -= sum * 0.15;
                }
            }
            else if (typePeople == "Business")
            {
                if (dayType == "Friday") //Friday 10.90 
                {
                    sum = peopleNum * 10.90;
                }
                else if (dayType == "Saturday")//Saturday 15.60  
                {
                    sum = peopleNum * 15.60;
                }
                else if (dayType == "Sunday") //Sunday  16 
                {
                    sum = peopleNum * 16;
                }

                if (peopleNum >= 100)
                {
                    switch (dayType)
                    {
                        case "Friday":
                            sum = sum - 10 * 10.90;
                            break;
                        case "Saturday":
                            sum = sum - 10 * 15.60;
                            break;
                        case "Sunday":
                            sum = sum - 10 * 16;
                            break;
                    }
                }
            }
            else if (typePeople == "Regular")
            {
                if (dayType == "Friday") //Friday 15
                {
                    sum = peopleNum * 15;
                }
                else if (dayType == "Saturday")//Saturday  20 
                {
                    sum = peopleNum * 20;
                }
                else if (dayType == "Sunday") //Sunday  22.50
                {
                    sum = peopleNum * 22.50;
                }

                if ( peopleNum >= 10 && peopleNum <=20)
                {
                    sum -= sum * 0.05;
                }
            }


            Console.WriteLine($"Total price: {sum:f2}");

        }
    }
}
