using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CardElements
{
    /// <summary>
    /// Insurance policy description
    /// </summary>
    public class InsurancePolicy : ElectronicCard
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
        /// User insurance number
        /// </summary>
        public string InsuranceNumber { get; set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="Name">User name</param>
        /// <param name="Surname">User surname</param>
        /// <param name="Number">Card number</param>
        /// <param name="Middlename">User middlename</param>
        /// <param name="Sex">User sex</param>
        /// <param name="DateOfBirth">User date of birth</param>
        /// <param name="InsuranceNumber">User insurance number</param>
        public InsurancePolicy(string Name, string Surname, int Number, string Middlename, string Sex, DateTime DateOfBirth, string InsuranceNumber) : base(Name, Surname, Number)
        {
            this.Middlename = Middlename;
            this.Sex = Sex;
            this.DateOfBirth = DateOfBirth;
            this.InsuranceNumber = InsuranceNumber;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public InsurancePolicy() { }

        /// <summary>
        /// Method overriding ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return "Страховой полис:\n\t\t" + base.ToString() + "\tОтчество: " + Middlename.ToString() + "\tПол: " + Sex + "\tДата рождения: " + DateOfBirth.ToShortDateString() + "\tСтраховой номер: " + InsuranceNumber;
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
            InsurancePolicy card = (InsurancePolicy)obj;
            if (Number != card.Number || Surname != card.Surname || Name != card.Name || Middlename != card.Middlename || Sex != card.Sex || DateOfBirth != card.DateOfBirth || InsuranceNumber != card.InsuranceNumber)
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
