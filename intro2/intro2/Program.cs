namespace intro2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Värvide valikus on: red, blue, green ja white. + Sisesta värv");


            Console.WriteLine("Sisesta värv");

            string color = Console.WriteLine();
            if (varv == "red")
            {
                Console.WriteLine("See on punane värv");
            }
            else if (varv == "blue")
            {
                Console.WriteLine("See on sinine");
            }
            else if (varv == "green")
            {
                Console.WriteLine("See on roheline");
            }
            else if (varv == "white")
            {
                Console.WriteLine("See on valge");
            }
            else
            {
                Console.WriteLine("Sisestasid suvalise värvi");
            }
        }
    }
}