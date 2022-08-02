using System;

namespace Exercise1
{
    internal class Program
    {
        static void Main(string[] arg)
        {
            int[] myArray = { 1, 2, 3, 4, 5, 6, };
            bool answer = false;
            for (int i = 0; i < myArray.Length; i++)
            {
                if(myArray[i] % 2 == 0)
                {
                    answer = false;
                }
                else
                {
                    answer = true;
                }
                Console.WriteLine("There is an odd number here");
            }
            
        }
    }
}
