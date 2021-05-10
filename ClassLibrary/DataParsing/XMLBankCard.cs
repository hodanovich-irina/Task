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
    /// Class for working with bank card and xml-file
    /// </summary>
    public class XMLBankCard
    {
        /// <summary>
        /// Method for adding a new entry in xml-file
        /// </summary>
        /// <param name="card">Bank card</param>
        public void XMLCreateBankCard(BankCard card) 
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"../../XMLFileCardInf.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement userElem = xDoc.CreateElement("bankCard");
            XmlElement a1 = xDoc.CreateElement("number");
            XmlElement a2 = xDoc.CreateElement("surname");
            XmlElement a3 = xDoc.CreateElement("name");
            XmlElement a4 = xDoc.CreateElement("endOfAction");
            XmlElement a5 = xDoc.CreateElement("bankName");
            XmlElement a6 = xDoc.CreateElement("cardNumber");
            XmlElement a7 = xDoc.CreateElement("cardType");
            XmlElement a8 = xDoc.CreateElement("cvc");
            a1.AppendChild(xDoc.CreateTextNode(card.Number.ToString()));
            a2.AppendChild(xDoc.CreateTextNode(card.Surname));
            a3.AppendChild(xDoc.CreateTextNode(card.Name));
            a4.AppendChild(xDoc.CreateTextNode(card.EndOfAction.ToShortDateString()));
            a5.AppendChild(xDoc.CreateTextNode(card.BankName));
            a6.AppendChild(xDoc.CreateTextNode(card.CardNumber));
            a7.AppendChild(xDoc.CreateTextNode(card.CardType));
            a8.AppendChild(xDoc.CreateTextNode(card.CVC.ToString()));
            userElem.AppendChild(a1);
            userElem.AppendChild(a2);
            userElem.AppendChild(a3);
            userElem.AppendChild(a4);
            userElem.AppendChild(a5);
            userElem.AppendChild(a6);
            userElem.AppendChild(a7);
            userElem.AppendChild(a8);
            xRoot.AppendChild(userElem);
            xDoc.Save(@"../../XMLFileCardInf.xml");
        }

        /// <summary>
        ///  Method for showing entry from xml-file
        /// </summary>
        /// <param name="childnode">XmlNode</param>
        /// <returns>Bank card</returns>
        public BankCard XMLShowBankCard(XmlNode childnode)
        {
            BankCard card = new BankCard();
            foreach (XmlNode childnode1 in childnode.ChildNodes)
            {
                if (childnode1.Name == "number")
                    card.Number = Convert.ToInt32(childnode1.InnerText);
                if (childnode1.Name == "surname")
                    card.Surname = childnode1.InnerText;
                if (childnode1.Name == "name")
                    card.Name = childnode1.InnerText;
                if (childnode1.Name == "endOfAction")
                    card.EndOfAction = Convert.ToDateTime(childnode1.InnerText);
                if (childnode1.Name == "bankName")
                    card.BankName = childnode1.InnerText;
                if (childnode1.Name == "cardNumber")
                    card.CardNumber = childnode1.InnerText;
                if (childnode1.Name == "cardType")
                    card.CardType = childnode1.InnerText;
                if (childnode1.Name == "cvc")
                    card.CVC = Convert.ToInt32(childnode1.InnerText);
            }
            return card;
        }
    }
}
