using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EuropeanWar3Library
{
    public class Country
    {
        public static int MIN_TECH = 0;
        public static int MAX_TECH = 5;

        public string name { get; set; }
        public int ai { get; set; }
        public int money { get; set; }
        public int industry { get; set; }
        public int techlevel { get; set; }
        public Alliance alliance { get; set; }
        public Color color { get; set; }

        public Country()
        {

        }

        public Country(XElement countryElement)
        {
            name = countryElement.Attribute("name").Value;
            ai = int.Parse(countryElement.Attribute("ai").Value);
            money = int.Parse(countryElement.Attribute("money").Value);
            industry = int.Parse(countryElement.Attribute("industry").Value);
            techlevel = int.Parse(countryElement.Attribute("techlevel").Value);
            alliance = (Alliance)Enum.Parse(typeof(Alliance), countryElement.Attribute("alliance").Value);
            color = new Color
            {
                r = int.Parse(countryElement.Attribute("r").Value),
                g = int.Parse(countryElement.Attribute("g").Value),
                b = int.Parse(countryElement.Attribute("b").Value),
                a = int.Parse(countryElement.Attribute("a").Value)
            };
        }

        public XElement getXElement()
        {
            XElement countryElement = new XElement("country");
            countryElement.SetAttributeValue("name", name);
            countryElement.SetAttributeValue("ai", ai.ToString());
            countryElement.SetAttributeValue("money", money.ToString());
            countryElement.SetAttributeValue("industry", industry.ToString());
            countryElement.SetAttributeValue("techlevel", techlevel.ToString());
            countryElement.SetAttributeValue("alliance", alliance.ToString("G"));
            countryElement.SetAttributeValue("r", color.r.ToString());
            countryElement.SetAttributeValue("g", color.g.ToString());
            countryElement.SetAttributeValue("b", color.b.ToString());
            countryElement.SetAttributeValue("a", color.a.ToString());

            return countryElement;
        }
    }
}
