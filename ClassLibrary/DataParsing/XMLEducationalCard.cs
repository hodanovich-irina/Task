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
    /// Class for working with educational card and xml-file
    /// </summary>
    public class XMLEducationalCard
    {
        /// <summary>
        /// Method for adding a new entry in xml-file
        /// </summary>
        /// <param name="card">Educational card</param>
        public void XMLCreateEducationalCard(EducationalCard card) 
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("XMLFileCardInf.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement userElem = xDoc.CreateElement("educationalCard");
            XmlElement a1 = xDoc.CreateElement("number");
            XmlElement a2 = xDoc.CreateElement("surname");
            XmlElement a3 = xDoc.CreateElement("name");
            XmlElement a4 = xDoc.CreateElement("middlename");
            XmlElement a5 = xDoc.CreateElement("startYear");
            XmlElement a6 = xDoc.CreateElement("institutionName");
            a1.AppendChild(xDoc.CreateTextNode(card.Number.ToString()));
            a2.AppendChild(xDoc.CreateTextNode(card.Surname));
            a3.AppendChild(xDoc.CreateTextNode(card.Name));
            a4.AppendChild(xDoc.CreateTextNode(card.Middlename));
            a5.AppendChild(xDoc.CreateTextNode(card.StartYear.ToShortDateString()));
            a6.AppendChild(xDoc.CreateTextNode(card.InstitutionName));
            userElem.AppendChild(a1);
            userElem.AppendChild(a2);
            userElem.AppendChild(a3);
            userElem.AppendChild(a4);
            userElem.AppendChild(a5);
            userElem.AppendChild(a6);
            xRoot.AppendChild(userElem);
            xDoc.Save("XMLFileCardInf.xml");
        }

        /// <summary>
        ///  Method for showing entry from xml-file
        /// </summary>
        /// <param name="childnode">XmlNode</param>
        /// <returns>Educational card</returns>
        public EducationalCard XMLShowEducationalCard(XmlNode childnode)
        {
            EducationalCard card = new EducationalCard();
            foreach (XmlNode childnode1 in childnode.ChildNodes)
            {
                if (childnode1.Name == "number")
                    card.Number = Convert.ToInt32(childnode1.InnerText);
                if (childnode1.Name == "surname")
                    card.Surname = childnode1.InnerText;
                if (childnode1.Name == "name")
                    card.Name = childnode1.InnerText;
                if (childnode1.Name == "middlename")
                    card.Middlename = childnode1.InnerText;
                if (childnode1.Name == "startYear")
                   card.StartYear = Convert.ToDateTime(childnode1.InnerText);
                if (childnode1.Name == "institutionName")
                    card.InstitutionName = childnode1.InnerText;
            }
            return card;
        }
    }
}
