using System;
namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiumet? Svara j för ja och n gör nej.");
            string svar = Console.ReadLine();

            Console.WriteLine("Hur gammal är du?");
            string åldertext = Console.ReadLine();
            int ålder = int.Parse(åldertext);

            if (ålder < 22 && svar == "j")
            {
                Console.WriteLine("Vi vill gärna anställa dig");
            }
            else
            {
                Console.WriteLine("Tyvärr vi söker annan personal.");
            }
             Console.ReadKey();
        }
    }
}