using System;
using System.Threading;

namespace CasserCodePIN
{
    class Program
    {
        public static void Main(string[] args)
        {
            // start représente l'heure de démarrage du programme
            DateTime start = DateTime.Now;
            Console.WriteLine("Début du programme");
            Random rnd = new Random();
            int codeSecret = rnd.Next(9999);
            // booléen qui indique si on a trouvé le code secret
            bool trouve = false;
            // compteur de boucle
            int i = 0;
            while (i < 10000 && trouve == false)
            {
                Console.WriteLine(i + " ");
                // si on trouve le code pin, il faut afficher i et interrompre la boucle
                if (i == codeSecret)
                {
                    Console.WriteLine("Code PIN trouvé : " + i);
                    trouve = true;
                }
                Thread.Sleep(1000);
                i++;
            }
            Console.WriteLine("Fin du programme");
            // durée du programme = heure de fin - heure de démarrage
            TimeSpan duree = DateTime.Now - start;
            Console.WriteLine("durée du programme : " + duree);
            Console.Write("Press any key to continue . . . ");
            Console.ReadKey(true);
        }
    }
}
