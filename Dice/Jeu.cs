using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class Jeu
    {
        private const int NBR_MAX_DES = 15;
        private const int NBR_MIN_DES = 1;


        private List<De> listeDés = new List<De>();

        /// <summary>
        /// Constructeur de jeu avec au moins un dé
        /// </summary>
        public Jeu() {

            listeDés.Add(new De());
        }

        /// <summary>
        /// Ajout d'un dé si on gagne
        /// </summary>
        public void GagnerUnDe() {
            if (listeDés.Count <= 15)
            {
                listeDés.Add(new De());
                Console.WriteLine("Félicitations tu gagnes un dé supplémentaire !");
            }
            else
            {
                Console.WriteLine("Tu as atteint le nombre maximum de dé jeune joueur !");
            }
        }

        /// <summary>
        /// Perte d'un dé
        /// </summary>
        public void PerdreUnDe() {
            if (listeDés.Count > NBR_MIN_DES)
            {
                listeDés.RemoveAt(0);
                Console.WriteLine("Dommage tu as perdu un dé jeune champion !");
            }
            else
            {
                Console.WriteLine("Il faut garder au moins un dé jeune joueur !");
            }
        }

        /// <summary>
        /// Fait avancer le joueur d'un nombre de cases en fonction du résultat du jeté de tous ses dés
        /// </summary>
        public void Jouer() {
            Console.WriteLine("Le joueur lance {0} dés et avance avance de {1} cases.",listeDés.Count, JeterTousLesDés());
        }


        /// <summary>
        /// Jeter tous les dés pour calculer le nombre de cases dont il faudra avancer
        /// </summary>
        /// <returns></returns>
        private int JeterTousLesDés() {

            int nbrCases = 0;
            foreach (De leDé in listeDés)
            {
                leDé.jeter();
                nbrCases += leDé.FaceVisible;
            }

            return nbrCases;

        }

        
        

    }
}
