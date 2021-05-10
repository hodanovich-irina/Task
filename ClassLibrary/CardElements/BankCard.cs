using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.CardElements
{
    /// <summary>
    /// Bank card description 
    /// </summary>
    public class BankCard : ElectronicCard
    {
        /// <summary>
        /// End of card action
        /// </summary>
        public DateTime EndOfAction { get; set; }

        /// <summary>
        /// Card bank name
        /// </summary>
        public string BankName { get; set; }

        /// <summary>
        /// Card number
        /// </summary>
        public string CardNumber { get; set; }

        /// <summary>
        /// Type of card
        /// </summary>
        public string CardType { get; set; }

        /// <summary>
        /// Card CVC code
        /// </summary>
        public int CVC { get; set; }

        /// <summary>
        /// Constructor with parameters
        /// </summary>
        /// <param name="Name">User name</param>
        /// <param name="Surname">User surname</param>
        /// <param name="Number">Card number</param>
        /// <param name="EndOfAction">End of card action</param>
        /// <param name="BankName">Bank name</param>
        /// <param name="CardNumber">Card number</param>
        /// <param name="CardType">Type of card</param>
        /// <param name="CVC">Card CVC code</param>
        public BankCard(string Name, string Surname, int Number, DateTime EndOfAction, string BankName, string CardNumber, string CardType, int CVC) : base(Name, Surname, Number)
        {
            this.EndOfAction = EndOfAction;
            this.BankName = BankName;
            this.CardNumber = CardNumber;
            this.CardType = CardType;
            this.CVC = CVC;
        }

        /// <summary>
        /// Empty constructor
        /// </summary>
        public BankCard() { }

        /// <summary>
        /// Method overriding ToString()
        /// </summary>
        /// <returns>String</returns>
        public override string ToString() 
        {
            return "Банковская карта:\n\t\t" + base.ToString() + "\tДата окончания: " + EndOfAction.ToShortDateString() + "\tБанк: " + BankName + "\tНомер карты: " + CardNumber + "\tТип карты: " + CardType + "\tCVC-код: " + CVC.ToString();
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
            BankCard card = (BankCard)obj;
            if (Number != card.Number || Surname != card.Surname || Name != card.Name || EndOfAction != card.EndOfAction || BankName != card.BankName || CardNumber != card.CardNumber || CVC != card.CVC)
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
