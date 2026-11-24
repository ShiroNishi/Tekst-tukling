namespace TekstTukling
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Run();


        }
        static void Run()
        {
            Console.WriteLine("Hva vil du gjøre?");
            Console.WriteLine("  1. Reverser tekst");
            Console.WriteLine("  2. Endre vokaler");
            ChooseMode();
        }
        static void ChooseMode()
        {
            var mode = Console.ReadLine();

            if (mode != "1" && mode != "2")
            {
                Console.WriteLine("\nSkriv 1 eller 2\n");

                Run();
            }
            else
            {
                ChangeText(mode);
            }

            static void ChangeText(string? mode)
            {
                Console.WriteLine("\nSkriv hva som helst:");
                var text = Console.ReadLine();

                if (mode == "1")
                {
                    string reverse = "";
                    for (int i = text.Length - 1; i >= 0; i--)
                    {
                        reverse += text[i];
                    }

                    Console.WriteLine($"\nReversert tekst:\n  {reverse}\n");
                }
                else if (mode == "2")
                {
                    string newText = "";
                    foreach (char c in text)
                    {
                        if (c != 'e') newText += c;
                        else if (c == 'e') newText += 'a';
                    }
                    Console.WriteLine($"\nNy tekst:\n  {newText}\n");
                }
                Run();

            }

        }
    }
}
