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
    /// Class for working with passport and xml-file
    /// </summary>
    public class XMLPassport
    {
        /// <summary>
        /// Method for showing entry from xml-file
        /// </summary>
        /// <param name="childnode">XmlNode</param>
        /// <returns>Passport</returns>
        public Passport XMLShowPassport(XmlNode childnode)
        {
            Passport card = new Passport();
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
                if (childnode1.Name == "sex")
                    card.Sex = childnode1.InnerText;
                if (childnode1.Name == "dateOfBirth")
                    card.DateOfBirth = Convert.ToDateTime(childnode1.InnerText);
                if (childnode1.Name == "identificationeNumber")
                    card.IdentificationeNumber = childnode1.InnerText;
                if (childnode1.Name == "citizen")
                    card.Citizen = childnode1.InnerText;
                if (childnode1.Name == "start")
                    card.Start = Convert.ToDateTime(childnode1.InnerText);
            }
            return card;
        }

        /// <summary>
        /// Method for creating a new entry in xml-file
        /// </summary>
        /// <param name="card">Passport</param>
        public void XMLCreatePassport(Passport card)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(@"../../XMLFileCardInf.xml");
            XmlElement xRoot = xDoc.DocumentElement;
            XmlElement userElem = xDoc.CreateElement("passport");
            XmlElement a1 = xDoc.CreateElement("number");
            XmlElement a2 = xDoc.CreateElement("surname");
            XmlElement a3 = xDoc.CreateElement("name");
            XmlElement a4 = xDoc.CreateElement("middlename");
            XmlElement a5 = xDoc.CreateElement("sex");
            XmlElement a6 = xDoc.CreateElement("dateOfBirth");
            XmlElement a7 = xDoc.CreateElement("identificationeNumber");
            XmlElement a8 = xDoc.CreateElement("citizen");
            XmlElement a9 = xDoc.CreateElement("start");
            a1.AppendChild(xDoc.CreateTextNode(card.Number.ToString()));
            a2.AppendChild(xDoc.CreateTextNode(card.Surname));
            a3.AppendChild(xDoc.CreateTextNode(card.Name));
            a4.AppendChild(xDoc.CreateTextNode(card.Middlename));
            a5.AppendChild(xDoc.CreateTextNode(card.Sex));
            a6.AppendChild(xDoc.CreateTextNode(card.DateOfBirth.ToShortDateString()));
            a7.AppendChild(xDoc.CreateTextNode(card.IdentificationeNumber));
            a8.AppendChild(xDoc.CreateTextNode(card.Citizen));
            a9.AppendChild(xDoc.CreateTextNode(card.Start.ToShortDateString()));
            userElem.AppendChild(a1);
            userElem.AppendChild(a2);
            userElem.AppendChild(a3);
            userElem.AppendChild(a4);
            userElem.AppendChild(a5);
            userElem.AppendChild(a6);
            userElem.AppendChild(a7);
            userElem.AppendChild(a8);
            userElem.AppendChild(a9);
            xRoot.AppendChild(userElem);
            xDoc.Save(@"../../XMLFileCardInf.xml");
        }
    }
}
