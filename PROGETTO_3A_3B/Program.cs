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
            // Inizializiamo
            int num = 0,basi = 0, resto=0;
            do
            {
                // Inseriamo l'Input e l'Output che ci chiede di inserire il numero
                Console.WriteLine("inserisci un numero da convertire ");
                num = Convert.ToInt32(Console.ReadLine());
            } while (num < 0);
            do
            {
                Console.WriteLine("inserisci un numero da convertire tra 2 8 o 16");
               basi = Convert.ToInt32(Console.ReadLine());
            } while (basi != 2 && basi != 8 && basi != 16);

            while (num>1)
            {
                resto = num % basi;
                risultato=Convert.ToString(resto, basi) + risultato;
                num = num / basi;
            }

            risultato = Convert.ToString(resto, basi) + risultato;
            Console.WriteLine($"il umero convertito in base {basi} è {risultato}");
            Console.WriteLine("");

           

            Console.ReadLine();




        }
    }
}
