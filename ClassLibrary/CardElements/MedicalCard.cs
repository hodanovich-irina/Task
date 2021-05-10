using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CardElements
{
    /// <summary>
    /// Medical card description
    /// </summary>
    public class MedicalCard : ElectronicCard
    {
        /// <summary>
        /// User middlename
        /// </summary>
        public string Middlename { get; set; }

        /// <summary>
        /// User sex
        /// </summary>
        public string Sex { get; set; }

        /// <summary>
        /// User date of birth
        /// </summary>
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// User adress
        /// </summary>
        public string Adress { get; set; }

        /// <summary>
        /// User phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// User institution name
        /// </summary>
        public string InstitutionName { get; set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="Name">User name</param>
        /// <param name="Surname">User surname</param>
        /// <param name="Number">Card number</param>
        /// <param name="Middlename">User middlename</param>
        /// <param name="Sex">User sex</param>
        /// <param name="DateOfBirth">User date of birth</param>
        /// <param name="Adress">User adress</param>
        /// <param name="PhoneNumber">User phone number</param>
        /// <param name="InstitutionName">User institution name</param>
        public MedicalCard(string Name, string Surname,int Number,string Middlename, string Sex, DateTime DateOfBirth, string Adress, string PhoneNumber, string InstitutionName) : base(Name, Surname, Number) 
        {
            this.Middlename = Middlename;
            this.Sex = Sex;
            this.DateOfBirth = DateOfBirth;
            this.Adress = Adress;
            this.PhoneNumber = PhoneNumber;
            this.InstitutionName = InstitutionName;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public MedicalCard() { }

        /// <summary>
        /// Method overriding ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return "Медицинская карта:\n\t\t" + base.ToString() + "\tОтчество: " + Middlename + "\tПол: " + Sex + "\tДата рождения: " + DateOfBirth.ToShortDateString() + "\tАдрес: " + Adress + "\tНомер телефона: " + PhoneNumber + "\tНаименование учереждения: " + InstitutionName;
        }

        /// <summary>
        /// Method overriding Equals()
        /// </summary>
        /// <param name="obj">Object</param>
        /// <returns>True or false</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;
            MedicalCard card = (MedicalCard)obj;
            if (Number != card.Number || Surname != card.Surname || Name != card.Name || Middlename != card.Middlename || Sex != card.Sex || DateOfBirth != card.DateOfBirth || Adress != card.Adress || PhoneNumber != card.PhoneNumber || InstitutionName != card.InstitutionName)
                return false;
            return true;
        }

        /// <summary>
        /// Method overriding GetHashCode()
        /// </summary>
        /// <returns>Hash-code</returns>
        public override int GetHashCode()
        {
            return Number;
        }
    }
}
