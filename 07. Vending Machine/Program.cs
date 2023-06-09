namespace _07._Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            string input;

            while ((input = Console.ReadLine()) != "Start")                             
            {                                                                           
                double coin = double.Parse(input);                                      
                switch (coin)                                                           
                {                                                                       
                    case 0.1:                                                           
                    case 0.2:                                                           
                    case 0.5:                                                           
                    case 1:                                                             
                    case 2:                                                             
                        sum += coin;                                                    
                        break;                                                          
                    default:                                                            
                        Console.WriteLine($"Cannot accept {coin}");                     
                        break;                                                          
                }                                                                       
            }                                                                           

            string food;

            while ((food = Console.ReadLine().ToLower()) != "end")
            {
                switch (food)
                {
                    case "nuts":
                        if (sum < 2) { Console.WriteLine("Sorry, not enough money"); }
                        else { sum -= 2.0; Console.WriteLine($"Purchased {food}"); }
                        break;
                    case "water":
                        if (sum < 0.7) { Console.WriteLine("Sorry, not enough money"); }
                        else { sum -= 0.7; Console.WriteLine($"Purchased {food}"); }
                        break;
                    case "crisps":
                        if (sum < 1.5) { Console.WriteLine("Sorry, not enough money"); }
                        else { sum -= 1.5; Console.WriteLine($"Purchased {food}"); }
                        break;
                    case "soda":
                        if (sum < 0.8) { Console.WriteLine("Sorry, not enough money"); }
                        else { sum -= 0.8; Console.WriteLine($"Purchased {food}"); }
                        break;
                    case "coke":
                        if (sum < 1.0) { Console.WriteLine("Sorry, not enough money"); }
                        else { sum -= 1.0; Console.WriteLine($"Purchased {food}"); }
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        break;
                }
            }

            Console.WriteLine($"Change: {sum:f2}");
        }
    }
}