namespace WhileDoTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rida = 1;

            while (rida <= 5)
            {
                int tulp = 1;

                while (tulp <= rida)
                {
                    Console.Write("* ");
                    tulp++;
                }

                Console.WriteLine();
                rida++;
            }
        }
    }
}