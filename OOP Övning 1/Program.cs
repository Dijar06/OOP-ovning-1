using System;

namespace OOP_Övning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 bil1 = new Class1("Audi", "RS6", 2024, 900, 300);
            Console.WriteLine("Bil 1:");
            Console.WriteLine("Märke: " + bil1.Märke);
            Console.WriteLine("Modell: " + bil1.Modell);
            Console.WriteLine("Årsmodell: " + bil1.Årsmodell);
            Console.WriteLine("Hästkrafter: " + bil1.Hästkrafter);
            Console.WriteLine("Maxhastighet: " + bil1.Maxhastighet);
        }
    }
}