using NUnit.Framework.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculatrice
{
    public interface ILogger
    {
        void Log(string message);
    }
    public class Calculatrice
    {
        private readonly ILogger _logger;
        public Calculatrice(ILogger logger)
        {
            _logger = logger;
        }

        public int Additionner(int a, int b)
        {
            _logger.Log($"Addition de {a} et {b}");
            int somme = a + b;
            return somme;

        }
        public int Soustraire(int a, int b)
        {
            int différence = a - b;
            return différence;

        }
        public int Multiplier(int a, int b)
        {
            int produit = a * b;
            return produit;

        }
        public int Diviser(int a, int b)
        {
            int quotient = a / b;
            return quotient;

        }
        public int CalculerExposant(int a, int b)
        {
            int carre = 1;
            for (int i = 0; i < b; i++)
            {
                carre = carre * a;
            }

            return carre;
        }
        public double CalculerRacine(int a)
        {
            double racine = Math.Sqrt(a);

            return racine;
        }
        public int ValeurAbsolue(int a)
        {
            return Math.Abs(a);
        }
        public int Modulo(int a, int b)
        {
            int reste = a % b;
            return reste;
        }
        public int Factorielle(int a)
        {
            int produit = 1;
            for (int i = 1; i <= a; i++)
            {
                produit = produit * i;
            }
            return produit;
        }
        public int PGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        /**
         * Calcule le PPCM de deux nombres
         * @param a, b
         * @return ppcm
         */ 
        public int PPCM(int a, int b)
        {
            int ppcm = 0;
            while (true)
            {
                if (ppcm % a == 0 && ppcm % b == 0)
                {
                    return ppcm;
                }
                ++ppcm;
            }
        }
    }
}
