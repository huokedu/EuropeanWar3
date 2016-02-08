using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EuropeanWar3Library
{
    public class Area
    {
        public static int MAX_ARMY = 4;

        public int id { get; set; }
        public Construction construction { get; set; }
        public int level { get; set; }
        public Installation installation { get; set; }
        public string country { get; set; }
        public List<Army> armyList { get; set; }

        public Area()
        {
            armyList = new List<Army>();
            
        }

        public Area(XElement areaElement)
        {
            armyList = new List<Army>();

            id = int.Parse(areaElement.Attribute("id").Value);
            construction = (Construction)Enum.Parse(typeof(Construction), areaElement.Attribute("construction").Value);
            level = int.Parse(areaElement.Attribute("level").Value);
            installation = (Installation)Enum.Parse(typeof(Installation), areaElement.Attribute("installation").Value);
            country = areaElement.Attribute("country").Value;

            IEnumerable<XElement> armyElementList = areaElement.Elements("army");
            foreach (XElement armyElement in armyElementList)
            {
                armyList.Add(new Army(armyElement));
            }
        }

        public XElement getXElement()
        {
            XElement areaElement = new XElement("area");
            areaElement.SetAttributeValue("id", id.ToString());
            areaElement.SetAttributeValue("construction", construction.ToString("G"));
            areaElement.SetAttributeValue("level", level.ToString());
            areaElement.SetAttributeValue("installation", installation.ToString("G"));
            areaElement.SetAttributeValue("country", country);

            foreach (Army army in armyList)
            {
                areaElement.Add(army.getXElement());
            }

            return areaElement;
        }
    }
}
