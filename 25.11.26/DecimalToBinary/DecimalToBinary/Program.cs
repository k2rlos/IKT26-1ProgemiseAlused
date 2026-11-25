namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("Sisesta number");
            int num = Convert.ToInt32(Console.ReadLine());
            string binary = "";

            //otsida interetist koodiljik ülesse
            //peab olema while-ga tehtud

            int originalValue = num;
            while (num >= 1)
            {
                binary = (num % 2) + binary;
                num = num / 2;
            }

            Console.WriteLine("Binary: {0}", binary);
            Console.WriteLine("Verification: {0} decimal = {1} binary", originalValue, binary);
        }
    }
}
