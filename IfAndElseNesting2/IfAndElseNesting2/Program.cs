namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("teise else if-i sisse panna if ja else nestimine");
            Console.WriteLine("sisesta oma vanus");
            int vanus = Convert.ToInt32(Console.ReadLine());

            if (vanus >= 18)
            {
                Console.WriteLine("Oled täisealine");
            }
            else
            {
                Console.WriteLine("Oled alaealine");
            }
        }
    }
}
