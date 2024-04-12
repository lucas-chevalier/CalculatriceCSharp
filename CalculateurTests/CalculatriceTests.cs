using Moq;
using NUnit.Framework;
using System.Security.AccessControl;

namespace Calculatrice
{
    [TestFixture]
    public class CalculatriceTests
    {
        private Calculatrice calculatrice;
        private Mock<ILogger> logger;

        [SetUp]
        public void Setup()
        {
            logger = new Mock<ILogger>();
            calculatrice = new Calculatrice(logger.Object);
        }


        [Test]
        public void Additionner_DeuxNombres_RetourneLeurSomme()
        {
            int nombreA = 5;
            int nombreB = 7;
            int resultatAttendu = 12;


            int resultat = calculatrice.Additionner(nombreA, nombreB);

            logger.Verify(x => x.Log($"Addition de {nombreA} et {nombreB}"), Times.Once);
            
            Assert.That(resultat, Is.EqualTo(resultatAttendu), "L'addition de 5 et 7 doit être égale à 12");

        }
        [Test]
        public void Soustraire_DeuxNombres_RetourneLeurDifférence()
        {
            int nombreA = 10;
            int nombreB = 5;
            int resultatAttendu = 5;


            int resultat = calculatrice.Soustraire(nombreA, nombreB);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "La différence de 10 et 5 doit être égale à 5");

        }
        [Test]
        public void Multiplier_DeuxNombres_RetourneLeurProduit()
        {
            int nombreA = 5;
            int nombreB = 7;
            int resultatAttendu = 35;


            int resultat = calculatrice.Multiplier(nombreA, nombreB);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "La multiplication de 5 et 7 doit être égale à 35");

        }
        [Test]
        public void Diviser_DeuxNombres_RetourneLeurQuotient()
        {
            int nombreA = 10;
            int nombreB = 5;
            int resultatAttendu = 2;


            int resultat = calculatrice.Diviser(nombreA, nombreB);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "La division de 10 par 5 doit être égale à 2");

        }
        [Test]
        public void CalculerExposantDUnNombreAvecUnAutre_RetourneLeTotal()
        {
            int nombreA = 10;
            int nombreB = 5;
            int resultatAttendu = 100000;


            int resultat = calculatrice.CalculerExposant(nombreA, nombreB);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "Le carre de 10 par 5 est égal à 100 000.");
        }
        [Test]
        public void CalculerLaRacineCarre_RetourneLaRacine()
        {
            int nombreA = 100;
            double resultatAttendu = 10;


            double resultat = calculatrice.CalculerRacine(nombreA);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "La racine carre de 100 est égale à 10.");
        }

        [Test]
        public void CalculerLeModulo_RetourneEntier()
        {
            int nombreA = 22;
            int nombreB = 5;
            int resultatAttendu = 2;


            int resultat = calculatrice.Modulo(nombreA, nombreB);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "Le modulo de 22 par 5 doit être égale à 2");

        }
        [Test]
        public void CalculerFactorielle_RetourneProduit()
        {
            int nombreA = 5;
            int resultatAttendu = 120;


            int resultat = calculatrice.Factorielle(nombreA);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "La factorielle de 5 doit être égale à 120");
        }
        [Test]
        public void CalculerValeurAbsolue_RetourneNombrePositif()
        {
            int nombreA = -5;
            int resultatAttendu = 5;


            int resultat = calculatrice.ValeurAbsolue(nombreA);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "La valeur absolue de -5 doit être égale à 5");
        }
        [Test]
        public void CalculerPGCD_RetournePGCD()
        {
            int nombreA = 360;
            int nombreB = 81;
            int resultatAttendu = 9;

            int resultat = calculatrice.PGCD(nombreA, nombreB);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "Le PGCD de 360 et 81 doit être 9");
        }
        [Test]
        public void CalculerPPCM_RetournePPCM()
        {
            int nombreA = 30;
            int nombreB = 45;
            int resultatAttendu = 90;

            int resultat = calculatrice.PGCD(nombreA, nombreB);

            Assert.That(resultat, Is.EqualTo(resultatAttendu), "Le PGCD de 360 et 81 doit être 9");
        }
    }
}