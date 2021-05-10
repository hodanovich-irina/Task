using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CardElements
{
    /// <summary>
    /// Electronic card description
    /// </summary>
    public abstract class ElectronicCard
    {
        /// <summary>
        /// User name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User surname
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        ///  Card number
        /// </summary>
        public int Number { get; set; }

        /// <summary>
        /// Empty construct
        /// </summary>
        public ElectronicCard() { }
        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="Name">User name</param>
        /// <param name="Surname">User surname</param>
        /// <param name="Number">Card number</param>
        public ElectronicCard(string Name, string Surname, int Number) 
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Number = Number;
        }

        /// <summary>
        /// Method overriding ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() 
        {
            return "№ электроной карты: " + Number.ToString() + "\tФамилия: " + Surname + "\tИмя: " + Name;
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
            ElectronicCard card = (ElectronicCard)obj;
            if (Number != card.Number || Surname != card.Surname || Name != card.Name)
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
