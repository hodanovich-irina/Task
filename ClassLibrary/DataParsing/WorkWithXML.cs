using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using ClassLibrary.CardElements;


namespace ClassLibrary.DataParsing
{
    /// <summary>
    /// Class for working with xml-file
    /// </summary>
    public class WorkWithXML
    {
        /// <summary>
        /// Method  for creating a list of cards from a xml-file
        /// </summary>
        /// <returns>List of cards</returns>
        public List<ElectronicCard> ShowXML() 
        {
            List<ElectronicCard> cards = new List<ElectronicCard>();
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLFileCardInf.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            ElectronicCard card = null;

            foreach (XmlNode xnode in xRoot)
            {

                if (xnode.Name == "bankCard") { 
                    XMLBankCard bankCard = new XMLBankCard();
                    card = bankCard.XMLShowBankCard(xnode);
                }

                if (xnode.Name == "educationalCard") 
                {
                    XMLEducationalCard educationalCard = new XMLEducationalCard();
                    card = educationalCard.XMLShowEducationalCard(xnode);
                }

                if (xnode.Name == "insurancePolicy") 
                { 
                    XMLInsurancePolicy insurancePolicy = new XMLInsurancePolicy();
                    card = insurancePolicy.XMLShowInsurancePolicy(xnode);
                }

                if (xnode.Name == "medicalCard") 
                {
                    XMLMedicalCard medicalCard = new XMLMedicalCard();
                    card = medicalCard.XMLShowMedicalCard(xnode);
                }

                if (xnode.Name == "passport")
                {
                    XMLPassport passport = new XMLPassport();
                    card = passport.XMLShowPassport(xnode);
                }
                cards.Add(card);
                
            }
            return cards;
        }

        /// <summary>
        /// Get last card number in XML-file
        /// </summary>
        /// <returns>Card number</returns>
        public int GetLastNumber() 
        {
            int num = 0;
            foreach (var v in ShowXML()) 
                num = v.Number;
            return num;
        }
    }
}
