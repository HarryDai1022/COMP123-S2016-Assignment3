using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Author: Zun Dai
 * Student ID: 300839401
 * Date modified: 2016-07-02
 * Program description: Assigment3, Abstract Planet
 * 
 */

namespace COMP123_S2016_Assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************************* Giant Planet ******************************");
            Console.WriteLine();
            GiantPlanet myGiantPlanet = new GiantPlanet("Gas Giant", "Neptune", 49244, 86.81E24);
            Console.WriteLine(myGiantPlanet.ToString());
            Console.WriteLine();
            Console.WriteLine("******************************* Terrestrial Planet ******************************");
            Console.WriteLine();
            GiantPlanet myTerrestrialPlanet = new GiantPlanet("Terrestrial Planet", "Venus", 12104, 86.81E24);
            Console.WriteLine(myTerrestrialPlanet.ToString());
            Console.WriteLine();

            waitForAnyKey();
        }

        public static void waitForAnyKey()
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
