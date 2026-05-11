using System;

namespace ciclu
{
    class Program
    {
        static void Main()
        {
            int [] number = new int [4];
            number[0] = 1;
            number[1] = 3;
            number[2] = 5;
            number[3] = 7;
            

            for (int i = 0 ; i < number.Length ; i++)
            {
                Console.WriteLine(" Number " + number[i]);
            }
            
            
        }
    }
}