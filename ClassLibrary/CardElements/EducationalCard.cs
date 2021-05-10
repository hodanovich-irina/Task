using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CardElements
{
    /// <summary>
    /// Educational card description 
    /// </summary>
    public class EducationalCard : ElectronicCard
    {
        /// <summary>
        /// User middlenmae
        /// </summary>
        public string Middlename { get; set; }

        /// <summary>
        /// Start of education year
        /// </summary>
        public DateTime StartYear { get; set; }

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
        /// <param name="StartYear">Start of education year</param>
        /// <param name="InstitutionName">User institution name</param>
        public EducationalCard(string Name, string Surname, int Number, string Middlename, DateTime StartYear, string InstitutionName) : base(Name, Surname, Number)
        {
            this.Middlename = Middlename;
            this.StartYear = StartYear;
            this.InstitutionName = InstitutionName;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public EducationalCard() { }

        /// <summary>
        /// Method overriding ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString()
        {
            return "Образовательная карта:\n\t\t" + base.ToString() + "\tОтчество: " + Middlename + "\tДата начала обучения: " + StartYear.ToShortDateString() + "\tУО: " + InstitutionName;
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
            EducationalCard card = (EducationalCard)obj;
            if (Number != card.Number || Surname != card.Surname || Name != card.Name || Middlename != card.Middlename || StartYear != card.StartYear || InstitutionName != card.InstitutionName)
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
