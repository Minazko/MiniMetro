using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Scripts
{
    public class Carte
    {
        private Case[,] cases;
        private Dictionary<enum_CaseCote, Case> voisinCase;

        public int Largeur
        {
            get
            {
                return 50;
            }
        }

        public int Longueur
        {
            get
            {
                return 50;
            }
        }

        internal Case[,] ListeCases
        {
            get
            {
                return cases;
            }

            set
            {
                cases = value;
            }
        }

        public Carte()
        {
            cases = new Case[3,3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    cases[i,j] = new Case(i, j);
                }
            }
        }
    }
}
