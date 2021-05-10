using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary.CardElements;

namespace ClassLibraryUnitTestProject
{
    /// <summary>
    /// Class for testing ClassLibrary
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Test for ToString()
        /// </summary>
        [TestMethod]
        public void TestToString()
        {
            BankCard card = new BankCard()
            {
                Number = 1,
                Name = "Alex",
                Surname = "Ivanov",
                EndOfAction = new DateTime(2002, 10, 10),
                BankName = "Belarusbank",
                CardNumber = "1275 6785 5678 6468",
                CardType = "Visa",
                CVC = 679
            };

            var except = "Банковская карта:\n\t\t№ электроной карты: 1\tФамилия: Ivanov\tИмя: Alex\tДата окончания: 10.10.2002\tБанк: Belarusbank\tНомер карты: 1275 6785 5678 6468\tТип карты: Visa\tCVC-код: 679";
            var actual = card.ToString();

            Assert.AreEqual(except, actual);
        }
        /// <summary>
        /// Test for Equals
        /// </summary>
        [TestMethod]
        public void TestEquals()
        {
            EducationalCard card = new EducationalCard()
            {
                Number = 1,
                Name = "Alex",
                Surname = "Ivanov",
                Middlename = "Ivanovich",
                StartYear = new DateTime(2002, 10, 10),
                InstitutionName = "BSU"
            };

            EducationalCard card1 = new EducationalCard();

            var actual = card.Equals(card1);

            Assert.IsFalse(actual);

        }

        /// <summary>
        /// Test for Equals
        /// </summary>
        [TestMethod]
        public void TestEquals2()
        {
            InsurancePolicy card = new InsurancePolicy()
            {
                Number = 1,
                Name = "Alex",
                Surname = "Ivanov",
                Middlename = "Ivanovich",
                Sex = "men",
                DateOfBirth = new DateTime(2002, 10, 10),
                InsuranceNumber = "685FJ9765BG"
            };

            InsurancePolicy card1 = new InsurancePolicy()
            {
                Number = card.Number,
                Name = card.Name,
                Surname = card.Surname,
                Middlename = card.Middlename,
                Sex = card.Sex,
                DateOfBirth = card.DateOfBirth,
                InsuranceNumber = card.InsuranceNumber
            };

            var actual = card.Equals(card1);

            Assert.IsTrue(actual);
        }
        /// <summary>
        /// Test for GerHashCode()
        /// </summary>
        [TestMethod]
        public void TestToGetHashCode()
        {
            MedicalCard card = new MedicalCard()
            {
                Number = 1,
                Name = "Alex",
                Surname = "Korneev",
                Middlename = "Ivanovich",
                Sex = "men",
                DateOfBirth = new DateTime(2002, 10, 10),
                Adress = "Gomel",
                PhoneNumber = "+375446788987",
                InstitutionName = "MEDCENTER"
            };

            var actual = card.GetHashCode();
            var except = card.Number;

            Assert.AreEqual(except, actual);
        }
        /// <summary>
        /// Field validation method
        /// </summary>
        [TestMethod]
        public void TestPassport()
        {
            Passport card = new Passport()
            {
                Number = 1,
                Name = "Alex",
                Surname = "Ivanov",
                Middlename = "Ivanovich",
                Sex = "men",
                DateOfBirth = new DateTime(2002, 10, 10),
                IdentificationeNumber = "689FV7906GG6",
                Citizen = "RB",
                Start = new DateTime(2002, 10, 10)

            };

            Assert.AreEqual("Alex", card.Name);
        }
    }
}
