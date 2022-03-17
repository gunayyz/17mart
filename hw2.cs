using System;

namespace hw2
{
    class Program
    {
        static void Main(string[] args)
        {
            //2. Bir integer eded qebul edib, bu ededi binary edede 
            //chevirende neche 1 oldugunu tapin. Mes: input 7(binary 
            //chevirende 111 alinir).output 3.
            
            Console.WriteLine(BinaryConverter(7));
        }
        static int BinaryConverter(int a )
        {
            int count = 0;
            while (a>0)
            {
                if (a % 2 == 1)
                {
                    count++;
                    
                }
                a = a / 2;



            }
            return count;
        }
        
    }

}
