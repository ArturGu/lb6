using System;

namespace OP_Lab_6
{
    class Program
    {
        [Flags]
        public enum System
        {
            None = 0,
            БюджетСофт = 1,
            APM_Торгівля = 2,
            ISpro = 3,
            TechExpert = 4,
            DROPT = 5,
            TQMSystem = 6,
        }

        static void Main(string[] args)
        {
                      
            Console.WriteLine("Перелiк усiх систем:");
            Console.WriteLine("1. KYIV_Soft.");
            Console.WriteLine("2. APM_Торгiвля.");
            Console.WriteLine("3. ISpro.");
            Console.WriteLine("4. TechExpert.");
            Console.WriteLine("5. DROPT.");
            Console.WriteLine("6. TQMSystem.");
            Console.WriteLine("\n"+"Якi програмнi продукти ви хочете придбати?");                    

            string text = Console.ReadLine();
            int n;
            string[] number = text.Split(',');

            Console.WriteLine("\n"+"Ви придбали:");
            for (int i = 0; i < number.Length; i++)
            {
                n = int.Parse(number[i]);
                var p = (System)n; 

                switch (n)
                {
                    case 1:                       
                        Console.WriteLine("1. "+p);
                        break;

                    case 2:
                        Console.WriteLine("2. " + p);
                        break;

                    case 3:
                        Console.WriteLine("3. " + p);
                        break;

                    case 4:
                        Console.WriteLine("4. " + p);
                        break;

                    case 5:
                        Console.WriteLine("5. " + p);
                        break;

                    case 6:
                        Console.WriteLine("6. " + p);
                        break;
                }
            }

            Console.WriteLine($"\n" + "Автор програми: Гутник Артур." + "\n");
            Console.WriteLine($"Повний перелiк програмних продуктiв:");

            Console.Write("   Системи для автоматизацiї облiку: ");
            Console.WriteLine($"БюджетСофт, APM_Торгiвля, ISpro.");

            Console.Write("   Системи для управлiння логiстикою: ");
            Console.WriteLine("TechExpert, DROPT, TQMSystem.");

            Console.ReadLine();
        }
    }
}
