using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EuropeanWar3Library
{
    public class Army
    {
        public static int MAX_LEVEL = 11;
        public ArmyType armyType { get; set; }
        public int level { get; set; }
        public Card card { get; set; }

        public Army()
        {
        }

        public Army(XElement armyElement)
        {
            if (armyElement.Attribute("type").Value.Equals("machine gun"))
            {
                armyElement.Attribute("type").Value = "machinegun";
            }
            armyType = (ArmyType)Enum.Parse(typeof(ArmyType), armyElement.Attribute("type").Value);
            level = int.Parse(armyElement.Attribute("level").Value);
            card = (Card)Enum.Parse(typeof(Card), armyElement.Attribute("cards").Value);
        }

        public XElement getXElement()
        {
            XElement armyElement = new XElement("army");
  
            armyElement.SetAttributeValue("type", armyType.ToString("G"));
            if (armyElement.Attribute("type").Value.Equals("machinegun"))
            {
                armyElement.SetAttributeValue("type", "machine gun");
            }
            armyElement.SetAttributeValue("level", level.ToString());
            armyElement.SetAttributeValue("cards", ((int)card).ToString());

            return armyElement;
        }
    }
}
