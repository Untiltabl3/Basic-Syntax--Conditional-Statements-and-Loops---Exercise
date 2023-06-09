namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());

            string ageOutput = "";

            if (age >= 0 && age <= 2)
            {
                ageOutput = "baby";
            }
            else if (age > 2 && age <= 13)
            {
                ageOutput = "child ";
            }
            else if (age > 13 && age <= 19)
            {
                ageOutput = "teenager ";
            }
            else if (age > 19 && age <= 65)
            {
                ageOutput = "adult";
            }
            else
            {
                ageOutput = "elder";
            }

            Console.WriteLine(ageOutput);
        }
    }
}