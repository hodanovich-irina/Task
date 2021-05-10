using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.CardElements;
using ClassLibrary.DataParsing;
using System.Xml;

namespace CommandLineInterface
{
    /// <summary>
    /// CLI
    /// </summary>
    public static class Menu
    {         
        /// <summary>
        /// List of cards
        /// </summary>
        private static List<ElectronicCard> cards = new List<ElectronicCard>();

        /// <summary>
        /// Card number
        /// </summary>
        private static int Number;

        /// <summary>
        /// Show main menu
        /// </summary>
        public static void ShowMenu()
        {
            WorkWithXML work = new WorkWithXML();
            Number = work.GetLastNumber() + 1;
            bool flag = true;
            int navigation;

            while (flag)
            {

                Console.WriteLine("\nCоздание универсальной электронной карты:\n\t1. Банковская карта;\n\t2. Образовательная карта;\n\t3. Страховой полис;\n\t4. Медицинская карта;\n\t5. Паспорт;\n\t6. Просмотреть записи;\n\t7. Выйти.");

                Console.WriteLine("\nВведите № операции для выполнения: ");
                navigation = Convert.ToInt32(Console.ReadLine());
                switch (navigation)
                {
                    case 1:
                        BankCard card = CreateBankCard();
                        XMLBankCard bankCard = new XMLBankCard();
                        bankCard.XMLCreateBankCard(card);
                        break;

                    case 2:
                        EducationalCard card1 = CreateEducationalCard();
                        XMLEducationalCard educationalCard = new XMLEducationalCard();
                        educationalCard.XMLCreateEducationalCard(card1);
                        break;

                    case 3:

                        InsurancePolicy card2 = CreateInsurancePolicy();
                        XMLInsurancePolicy insurancePolicy = new XMLInsurancePolicy();
                        insurancePolicy.XMLCreateInsurancePolicy(card2);
                        break;

                    case 4:
                        MedicalCard card3 = CreateMedicalCard();
                        XMLMedicalCard medicalCard = new XMLMedicalCard();
                        medicalCard.XMLCreateMedicalCard(card3);
                        break;

                    case 5:
                        Passport card4 = CreatePassport();
                        XMLPassport passport = new XMLPassport();
                        passport.XMLCreatePassport(card4);
                        break;

                    case 6:
                        foreach (var v in work.ShowXML())
                            Console.WriteLine(v.ToString());
                        Console.ReadKey();
                        break;

                    case 7:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("№ операции неверный,нажмите любую клавишу для продолжения и введите цифру от 1 до 7");
                        break;
                }
            }
        }

        /// <summary>
        /// Data input
        /// </summary>
        /// <returns>Bank card</returns>
        private static BankCard  CreateBankCard()
        {
            int Num = Number;
            Console.WriteLine("\nБанковская карта:");
            Console.WriteLine("Введите имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите дату окончания действия:");
            DateTime EndOfAction = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите наименование банка:");
            string BankName = Console.ReadLine();
            Console.WriteLine("Введите номер карты:");
            string CardNumber = Console.ReadLine();
            Console.WriteLine("Введите тип карты:");
            string CardType = Console.ReadLine();
            Console.WriteLine("Введите CVC-код");
            int CVC = Convert.ToInt32(Console.ReadLine());
            BankCard bankCard = new BankCard(Name, Surname, Num, EndOfAction, BankName, CardNumber, CardType, CVC);
            cards.Add(bankCard);
            Console.WriteLine("Ваша карта:\n" + bankCard.ToString());
            return bankCard;
        }

        /// <summary>
        /// Data input
        /// </summary>
        /// <returns>Educational card</returns>
        private static EducationalCard CreateEducationalCard() 
        {
            int Num = Number;
            Console.WriteLine("Образовательная карта:");
            Console.WriteLine("Введите имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string Middlename = Console.ReadLine();
            Console.WriteLine("Введите дату начала обучения:");
            DateTime StartYear = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите наименование учереждения образования:");
            string InstitutionName = Console.ReadLine();
            EducationalCard educationalCard = new EducationalCard(Name, Surname, Num, Middlename, StartYear, InstitutionName);
            cards.Add(educationalCard);
            Console.WriteLine("Ваша карта:\n" + educationalCard.ToString());
            return educationalCard;
        }

        /// <summary>
        /// Data input
        /// </summary>
        /// <returns>Insurance policy</returns>
        private static InsurancePolicy CreateInsurancePolicy() 
        {
            int Num = Number;
            Console.WriteLine("Страховой полис:");
            Console.WriteLine("Введите имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string Middlename = Console.ReadLine();
            Console.WriteLine("Введите пол:");
            string Sex = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите страховой номер:");
            string InsuranceNumber = Console.ReadLine();
            InsurancePolicy insurancePolicy = new InsurancePolicy(Name, Surname, Num, Middlename, Sex, DateOfBirth, InsuranceNumber);
            cards.Add(insurancePolicy);
            Console.WriteLine("Ваша карта:\n" + insurancePolicy.ToString());
            return insurancePolicy;
        }

        /// <summary>
        /// Data input
        /// </summary>
        /// <returns>Medical card</returns>
        private static MedicalCard CreateMedicalCard() 
        {
            int Num = Number;
            Console.WriteLine("Медицинская карта:");
            Console.WriteLine("Введите имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string Middlename = Console.ReadLine();
            Console.WriteLine("Введите пол:");
            string Sex = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите адрес:");
            string Adress = Console.ReadLine();
            Console.WriteLine("Введите наименование учереждения:");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Введите номер телефона:");
            string InstitutionName = Console.ReadLine();
            MedicalCard medicalCard = new MedicalCard(Name, Surname, Num, Middlename, Sex, DateOfBirth, Adress, PhoneNumber, InstitutionName);
            cards.Add(medicalCard);
            Console.WriteLine("Ваша карта:\n" + medicalCard.ToString());
            return medicalCard;
        }

        /// <summary>
        /// Data input
        /// </summary>
        /// <returns>Passport</returns>
        private static Passport CreatePassport() 
        {
            int num = Number;
            Console.WriteLine("Паспорт:");
            Console.WriteLine("Введите имя:");
            string Name = Console.ReadLine();
            Console.WriteLine("Введите фамилию:");
            string Surname = Console.ReadLine();
            Console.WriteLine("Введите отчество:");
            string Middlename = Console.ReadLine();
            Console.WriteLine("Введите пол:");
            string Sex = Console.ReadLine();
            Console.WriteLine("Введите дату рождения:");
            DateTime DateOfBirth = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Введите идентификационнай номер:");
            string IdentificationeNumber = Console.ReadLine();
            Console.WriteLine("Введите гражданство:");
            string Citizen = Console.ReadLine();
            Console.WriteLine("Введите дату получения:");
            DateTime Start = Convert.ToDateTime(Console.ReadLine());
            Passport passport = new Passport(Name, Surname, num, Middlename, Sex, DateOfBirth, IdentificationeNumber, Citizen, Start);
            cards.Add(passport);
            Console.WriteLine("Ваша карта:\n" + passport.ToString());
            return passport;
        }
        
    }
}
