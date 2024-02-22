using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DistributeurMethodes
{
    public class Outils
    {
        public static Dictionary<string, double[]> dictionnaryDistributeur = new Dictionary<string, double[]>();

        public static void Initialize()
        {

            dictionnaryDistributeur.Add("Coca", [1, 4]);
            dictionnaryDistributeur.Add("Sandwiches", [5, 2]);
            dictionnaryDistributeur.Add("Porte", [200, 3]);
        }

        public static string Menu(ref Dictionary<string, double[]> dictionaryDistributeur)
        {
            
            Console.WriteLine("Veuillez choisir une marchandise.");

            if (dictionaryDistributeur["Coca"][1] > 0)
            {
                Console.WriteLine("1 : Coca (1€)");
            }
            if (dictionaryDistributeur["Sandwiches"][1] > 0)
            {
                Console.WriteLine("2 : Sandwiches (5€)");
            }
            if (dictionaryDistributeur["Porte"][1] > 0)
            {
                Console.WriteLine("3 : Porte (200€)");
            }
            Console.WriteLine("4 : Quitter");
            
            return Console.ReadLine();
        }

        public static double Choix(string userMenu, ref Dictionary<string, double[]> dictionaryDistributeur)
        {
            Console.Clear();
            switch (userMenu)
            {
                case "1":
                    if (dictionaryDistributeur["Coca"][1] > 0)
                    {
                        dictionaryDistributeur["Coca"][1]--;
                        return dictionaryDistributeur["Coca"][0];

                    }
                    else {
                        Console.WriteLine("Il n'y a plus de Coca, Veuillez choisir autre chose.");
                        return 0;
                    }
                case "2":
                    if (dictionaryDistributeur["Sandwiches"][1] > 0)
                    {
                        dictionaryDistributeur["Sandwiches"][1]--;
                        return dictionaryDistributeur["Sandwiches"][0];
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a plus de Sandwiches, Veuillez choisir autre chose.");
                        return 0;
                    }
                case "3":
                    if (dictionaryDistributeur["Porte"][1] > 0)
                    {
                        dictionaryDistributeur["Porte"][1]--;
                        return dictionaryDistributeur["Porte"][0];
                    }
                    else
                    {
                        Console.WriteLine("Il n'y a plus de Porte, Veuillez choisir autre chose.");
                        return 0;
                    }
                case "4":
                    return 0;
                default:
                    Console.WriteLine("Erreur de choix !");
                    return 0;
            }
        }

        

    }
}
