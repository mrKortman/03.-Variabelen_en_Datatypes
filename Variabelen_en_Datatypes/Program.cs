using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabelen_en_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dit programma vraagt om een getal en converteerd deze dan naar een ander type.

            Console.Clear();

            Console.WriteLine("Geef een getal op :");
            string strGetal = Console.ReadLine();
            Console.WriteLine("U heeft het getal " + strGetal + " opgegeven dat is van het type : " + strGetal.GetType().ToString());
            Console.WriteLine("Converting...");
            int intGetal = Convert.ToInt32(strGetal);
            Console.WriteLine("Done!");
            Console.WriteLine("Het getal is nu gevonverteerd naar het type : " + intGetal.GetType().ToString());
            Console.ReadLine();


        }
    }
}
