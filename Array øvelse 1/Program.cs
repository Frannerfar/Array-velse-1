using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_øvelser_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] mynumber = new int[] { 12, 33, 532, 145, 1, 4565, 1 };

            mynumber[2] = 36534;
            int temp = mynumber[0];

            for (int i = 0; i < mynumber.Length; i++)
                // ændring af 3 element 
            {
                Console.WriteLine(mynumber[i]);
            }

            string[] spillere = { "Anders", "Else", "hans", "kaj", "inge", "kurt", "tove" };
            Console.WriteLine("hej");
        }
    }
}
