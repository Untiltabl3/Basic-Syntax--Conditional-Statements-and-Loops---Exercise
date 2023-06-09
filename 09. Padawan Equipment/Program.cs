namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyAmmount = double.Parse(Console.ReadLine());

            int studentCount = int.Parse(Console.ReadLine());

            double saberPrice = double.Parse(Console.ReadLine());
            //John should buy 10% more (taken from the students' count), rounded up to the next integer. 

            double robePrice = double.Parse(Console.ReadLine());

            double beltPrice = double.Parse(Console.ReadLine());
            // every 6th belt free.

            double totalPriceSaber = saberPrice * Math.Ceiling(studentCount * 1.1);

            double totalPriceRobe = robePrice * studentCount;

            double totalPriceBelt = beltPrice * (studentCount - Math.Floor(studentCount / 6.0));

            double sum = totalPriceBelt + totalPriceSaber + totalPriceRobe;


            if (moneyAmmount >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            //"The money is enough - it would cost {the cost of the equipment}lv." 
            else
            {
                Console.WriteLine($"John will need {Math.Abs(sum - moneyAmmount):f2}lv more.");
            }


            //" John will need {neededMoney}lv more." 
        }
    }
}