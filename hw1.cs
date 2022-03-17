using System;

namespace homework17
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(MaxArr(10,-90,90,0,-1,20,-100));
        }
        static int MaxArr(params int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i]>max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
    }
}

