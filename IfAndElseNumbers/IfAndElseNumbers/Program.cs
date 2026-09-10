namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kasutaja sisestab oma vanuse
            Console.Write("Sisesta oma vanus: ");
            int vanus = Convert.ToInt32(Console.ReadLine());

            // If-else tingimuslause
            if (vanus >= 18)
            {
                Console.WriteLine("Oled täisealine!");
            }
            else
            {
                Console.WriteLine("Oled alaealine!");
                //konsoolis sisestame numbri
                //see number salvestatakse string andmetüüpi
                //toimub kontroll, kas sisestatud väärtus on number
                //kasutada if ja else lauseid
            }
        }
    }
}
