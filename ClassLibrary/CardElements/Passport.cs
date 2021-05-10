using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CardElements
{
    /// <summary>
    /// Passport descrition
    /// </summary>
    public class Passport : ElectronicCard
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
        /// User identification number
        /// </summary>
        public string IdentificationeNumber { get; set; }

        /// <summary>
        /// User citizen
        /// </summary>
        public string Citizen { get; set; }

        /// <summary>
        /// Date of passport receipt
        /// </summary>
        public DateTime Start { get; set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="Name">User name</param>
        /// <param name="Surname">User surname</param>
        /// <param name="Number">Card number</param>
        /// <param name="Middlename">User middlename</param>
        /// <param name="Sex">User sex</param>
        /// <param name="DateOfBirth">User date of birth</param>
        /// <param name="IdentificationeNumber">User identificate number</param>
        /// <param name="Citizen">User citizen</param>
        /// <param name="Start">Date of passport receipt</param>
        public Passport(string Name, string Surname, int Number, string Middlename, string Sex, DateTime DateOfBirth, string IdentificationeNumber, string Citizen, DateTime Start) : base(Name, Surname, Number)
        {
            this.Middlename = Middlename;
            this.Sex = Sex;
            this.DateOfBirth = DateOfBirth;
            this.IdentificationeNumber = IdentificationeNumber;
            this.Citizen = Citizen;
            this.Start = Start;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public Passport() { }

        /// <summary>
        /// Method overriding ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return "Паспорт:\n\t\t" + base.ToString() + "\tОтчество: " + Middlename + "\tПол: " + Sex + "\tДата рождения: " + DateOfBirth.ToShortDateString() + "\tИдентификационный номер: " + IdentificationeNumber + "\tГражданство: " + Citizen + "\tДата получения: " + Start.ToShortDateString();
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
            Passport card = (Passport)obj;
            if (Number != card.Number || Surname != card.Surname || Name != card.Name || Middlename != card.Middlename || Sex != card.Sex || DateOfBirth != card.DateOfBirth || IdentificationeNumber != card.IdentificationeNumber || Citizen != card.Citizen || Start != card.Start)
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
