/*
Vrei să iei un credit de 40k euro de la bancă. Dobânda anuală cerută de bancă e de 7.57%. 
Creditul e pentru o perioadă de 20 ani. Contractul prevede restituirea în rate descrescătoare.
Calculează ce rată trebuie plătită în luna martie din al celui de al 4-lea an? 
Generalizează pentru orice sumă, perioadă și dobândă.
*/
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankRate
{
    [TestClass]
    public class BankRate
    {
        
       
        [TestMethod]
        public void BankRateForTheFiftyOneMonth()
        {
            Assert.AreEqual(26.6d, CalculateRate(300, 10, 5, 12));
        }

        public decimal CalculateRate(decimal totalSum, decimal interestPerYear, int currentMonth,int periodInMonths)
        {
            decimal principalRate =totalSum / periodInMonths;
            decimal interestPerMonth = interestPerYear / 12 / 100;
            decimal soldLeft =totalSum - (currentMonth - 1) * principalRate;

            return principalRate + soldLeft * interestPerMonth;
       }
    }
}
