using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ProblemaParchet
{
    [TestClass]
    public class ProblemaParchet
    {
        [TestMethod]
        public void TestMethod1()
        {
            double result = calculPlaciParchet(3, 3, 1, 0.5);
            Assert.AreEqual(12, result);
        }
        double calculPlaciParchet(int lungimeCamera,int latimeCamera, double lungimeBucataParchet,double latimeBucataParchet)
        {
            double dimensiuneCamera = lungimeCamera * latimeCamera;
            double dimensiuneParchet = lungimeBucataParchet * latimeBucataParchet;
            double nrBucatiPlaci = dimensiuneCamera / dimensiuneParchet;
            double pierderiParchet = 0.15 * Math.Ceiling(nrBucatiPlaci);//15% din placile de parchet
            double dimensiuneParchetnecesar = Math.Ceiling(nrBucatiPlaci) * dimensiuneParchet + (pierderiParchet);

            return Math.Ceiling(dimensiuneParchetnecesar);
        }
    }
}
