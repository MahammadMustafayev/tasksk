using System;

namespace Task2_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            switch (month)
            {

                case"Yanvar":
                case"Mart":
                case"May":
                case"Iyul":
                case"Avqust":
                case"Oktyabr":
                case"Dekabr":
            Console.WriteLine("Bu ayda 31 gün var.");
            break;


            case"Aprel":
            case"Iyun":
                case"Sentyabr":
                case"Noyabr":
            Console.WriteLine("Bu ayda 30 gün var");
            break;
            
                 case"Fevral":
            Console.WriteLine("Bu ayda 28 gün var");
                    break;
            
            default:
                Console.WriteLine("Bele ay yoxdur");
            break;
            }
        }
    }
}
