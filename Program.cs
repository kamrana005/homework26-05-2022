using System;

namespace homework_26052022
{
    internal class Program
    {
        static void Main(string[] args)
        
        {
            #region
            // - Verilmis adlar siyahisinda(string array) nece adin
            //uzunlugunun 5-den boyuk oldugunu tapan proqram
            string[] name = { "Abbas", "Arzu", "Abdulla", "Leman", "Suleyman", "Metanet" };
            int count = 0;
           
           



            for (int i = 0; i < name.Length; i++)

            {
                
                for (int j = 0; j < name[i].Length; j++)
                {
                    if (name[i].Length >5)
                    {
                        
                        count++;
                       // Console.WriteLine(name[i]);
                        break;

                    }

                    

                }

                
               
                    
            }
            Console.WriteLine("Adi 5 herfden boyuk olanlarin sayi:" + count);
            #endregion
            #region
            // Verilmis ededler siyahisindaki cut ededlerden ibaret
            // yeni bir array qaytaran method.// Misalcun gonderilmis
            // ededler siyahisinda {1,3,4,5,6} deyerleri varsa method geriye
            // {4,6} deyerlerinden ibaret bir array qaytarmalidir

            int[] numbers = { 5, 8, 7, 14, 18, 35, 37, 40, 98, 77, 68, 88 };
            Console.Write("{");
            for (int i = 0; i < numbers.Length; i++)
            {

                if (numbers[i] % 2 == 0)

                    Console.Write(numbers[i] + "," + " ");

            }
           
            Console.WriteLine("}");


            #endregion


        }
    }
}
