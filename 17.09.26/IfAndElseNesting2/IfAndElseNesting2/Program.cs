namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("teise else if-i sisse panna if ja else nestimine");
            //konsool küsib numbrit
            //if võrdub 12
            //elese if ja siia sisse omakorda teha if ning else. Else if tingimus on, et
            //muutuja on suurem, kui 20
            //else ja seal väljastab konsool teksti: Mingid kahtlased väärtused
            // Määrame vanuse
            Console.Write("Palun sisesta oma vanus: ");
            string sisend = Console.ReadLine();

            int vanus = int.Parse(sisend);

            if (vanus == 12)
            {
                Console.WriteLine("Vanus on täpselt 12.");
            }
            else if (vanus > 20)
            {
                if (vanus < 30)
                {
                    Console.WriteLine("Vanus on vahemikus 21 kuni 29.");
                }
                else
                {
                    Console.WriteLine("Vanus on 30 või vanem.");
                }
            }
            else
            {
                Console.WriteLine("Kahtlane vanus");
            }
        }
    }
}   
