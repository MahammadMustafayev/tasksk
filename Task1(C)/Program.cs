using System;

namespace Task1_C_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int m = 30;
            for (int n = 3; n<=m ; n++)
            {
                if (n % 7 == 0)
                {
                    count++;
                    
                }
                
            }
            Console.WriteLine(count);

        }
    }
}
