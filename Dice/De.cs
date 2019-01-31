using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice
{
    class De
    {
        private int nbrFaces;
        private int faceVisible = 1;
        private static Random nombreAleatoire;

        public De(int nbrFaces = 6, int faceVisible = 1) {
            nombreAleatoire = new Random();
            if (nbrFaces > 0)
            {
                this.nbrFaces = nbrFaces;
            }

            FaceVisible = faceVisible;
        }

        public int FaceVisible {
            get
            {
                return faceVisible;
            }

            set
            {
                if (value >= 1 && value <= nbrFaces)
                {
                    faceVisible = value;
                }
            }

        }


       

        public void jeter() {
            faceVisible = nombreAleatoire.Next(1,nbrFaces+1);
        }


        public bool Comparer(De deComparable) {

            return (faceVisible == deComparable.faceVisible && nbrFaces == deComparable.nbrFaces);
        }

    }
}
