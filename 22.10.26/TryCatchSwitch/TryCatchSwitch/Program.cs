namespace TryCatchSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");



            try
            {
                int nr = int.Parse(Console.ReadLine());

                switch (nr)
                {
                    case 1:
                        Console.WriteLine("Valisid 1");
                        break;

                    case 2:
                        Console.WriteLine("Valisid 2");
                        break;
                }

            }
            //vormi viga
            catch (FormatException)
            {
                Console.WriteLine("Palun sisesta number");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Palun sisesta number");
            }
        }
    }
}
