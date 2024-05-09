using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    internal class Program

    {
        public static int linearSearch(int[] a, int key)
        {
            int i = -1;

            for(int j = 0; j < a.Length;j++)
            {
                if (a[j] == key)
                {
                    i = j;
                    return i;
                }
            }


      
                Console.WriteLine("Aranan değer bulunamadı...");
           
            return i;
        }


        static void Main(string[] args)
        {

            int[] array = { 4, 1, 2, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 };

           
            Console.WriteLine(linearSearch(array, 6));
            Console.ReadKey();
  



        }
    }
}
