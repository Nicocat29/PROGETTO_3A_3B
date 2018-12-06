using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROGETTO_3A_3B
{
    class Program
    {
        static void Main(string[] args)
        {
            string risultato = "";
            int num = 255;
            Console.WriteLine("inserisci un numero da convertire in binario");
            num = Convert.ToInt32(Console.ReadLine());
            
            while(num>1)
            {
                int resto =num % 2;
                risultato = Convert.ToString(resto) + risultato;
                num = num / 2;
            }
            risultato = Convert.ToString(num) + risultato;
            Console.WriteLine($"il numero binario è{risultato}");




        }
    }
}
