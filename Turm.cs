/***********************************************************************************************
 * Übungsnr:        09                                     
 * Programmname:    Turm                                  
 * Autor:           karlof002  
 * Klasse:          1BHIF
 * Datum:           11.11.2013                               
 * ------------------------------------------------ 
 * Kurzbeschreibung:      
 * Gibt eine Turmrechnung aus
 * ************************************************
*/


using System;

namespace Turm
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Mit welcher Zahl wollen Sie den Turm starten?");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= 9; i++)
            {
                Console.WriteLine("{0,10} * {1}", number, i);
                number = number * i;
            }
            for (int i = 9; i >=2; i--)
            {
                Console.WriteLine("{0,10} / {1}", number, i);
                number = number / i;
            }
            Console.WriteLine("{0,10}",number);
        }
    }
}
