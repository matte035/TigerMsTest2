using Microsoft.VisualStudio.TestTools.UnitTesting;
using Project_Tiger_2._0;

namespace MSTigerTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        [Description("Insättning")]

        public void DepositMoneyToAccount_Test()
        {
            //Arrange

            Customer custDepo = new Customer()
            {

            };

            //Act
            
            custDepo.CreateNewBankAccount("SEK", "TestkontoInstättning", 5000);
            custDepo.DepositMoneyToAccount(0, 5000);

            var actual = custDepo.listOfBankAccounts[0].AccountBalance;
            var expect = 10000;

            //Assert

            Assert.AreEqual(expect, actual);


        }

        [TestMethod]
        [Description("Testar vad som händer om inte rätt valuta skapas")]

        public void CreateNewBankAccount_Test_Currency()
        {
            //Arrange
            Customer customerCurrency = new Customer()
            {

            };

            //Act
            customerCurrency.CreateNewBankAccount("Bit", "TestAccountName", 1000);
            //var expected = false;
            var actual = customerCurrency.ValidCurrency;
            //Assert
            Assert.IsFalse(actual);
            System.Console.WriteLine("Testet funkade");

        }

        [TestMethod]
        [Description("Testar vad som händer när man tar bort kontoRe")]
        public void RemoveAccount_Test()
        {
            //Arrange

            Customer customer = new Customer();
            {



            };
            customer.CreateNewBankAccount("SEK", "TestAccountName", 0);
            customer.RemoveExistingBankAccount(0);
            //Act

            var actual = customer.listOfBankAccounts.Exists(x => x.AccountName == "TestAccountName");
            var expected = false;

            //Assert

            Assert.AreEqual(expected, actual);



        }
    }
}
