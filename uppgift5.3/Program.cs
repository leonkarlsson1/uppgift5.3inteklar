using System;
namespace Uppgift_5._3
{
    class program
    {
        static void Main(string[] args)
        {
            string[] frågor = {"hur gammal är jag", "Hur mår du idag", "vem är värdens bästa fotbollspelare", "vem är leon"};
            string[] svar = { "12", "bra", "leon", "leon" };
            bool spela=true;

            while (spela = true) ;
            {
                Console.WriteLine();
                Console.WriteLine("valj ett tal mellan 1-4");
                int val=int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine(frågor[val - 1]);
                string val2=Console.ReadLine();
            }
            else ("du svarade fel");
        }
    }
}