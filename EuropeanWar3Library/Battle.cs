using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Schema;

namespace EuropeanWar3Library
{
    public class Battle
    {
        public string battleName { get; set; }
        public int map { get; set; }
        public List<Country> countryList { get; set; }
        public List<Area> areaList { get; set; }

        public Battle()
        {
            countryList = new List<Country>();
            areaList = new List<Area>();
            battleName = "empire_gb1";
            map = 1;
        }

        public XElement getXElement()
        {
            XElement battle = new XElement("battle");
            battle.SetAttributeValue("map", map);
            if (battleName != "")
            {
                battle.SetAttributeValue("areasenable", battleName + ".bin");
            }
            
            XElement countryNode = new XElement("list");
            countryNode.SetAttributeValue("name", "country");
            foreach (Country country in countryList)
            {
                countryNode.Add(country.getXElement());
            }

            XElement areaNode = new XElement("list");
            areaNode.SetAttributeValue("name", "area");
            foreach (Area area in areaList)
            {
                areaNode.Add(area.getXElement());
            }

            battle.Add(countryNode);
            battle.Add(areaNode);
            return battle;
        }

        public void SaveFile(string filePath)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            settings.IndentChars = "    ";
            using (XmlWriter xw = XmlWriter.Create(filePath, settings))
            {
                getXElement().Save(xw);
            }

        }

        public string ReadFile(string filePath)
        {
            XDocument battleXml = new XDocument();
            battleXml = XDocument.Load(filePath, LoadOptions.PreserveWhitespace | LoadOptions.SetLineInfo | LoadOptions.SetBaseUri);

            XmlSchemaSet schemas = new XmlSchemaSet();
            schemas.Add("", "Battle.xsd");
            schemas.Compile();
            String errorMessage = "";

            Console.WriteLine("Attempting to validate");
            bool errors = false;
            battleXml.Validate(schemas, (o, e) =>
            {
                errorMessage += "XML " + e.Severity + ": " + e.Message + "(Line " + e.Exception.LineNumber + ")" + "\n";
                errors = true;
            });

            Console.WriteLine("Reading Xml {0}", errors ? "did not validate" : "validated");
            Console.WriteLine();

            if (errors) { return errorMessage; }

            IEnumerable<XElement> countryNode;
            IEnumerable<XElement> areaNode;
      
            if (battleXml.Element("battle").Attribute("areasenable") != null)
            {
                battleName = battleXml.Element("battle").Attribute("areasenable").Value;
                battleName = battleName.Substring(0, battleName.IndexOf("."));
            }
            else
            {
                battleName = "";
            }

            map = int.Parse(battleXml.Element("battle").Attribute("map").Value);
            countryNode = battleXml.Element("battle").Elements("list").Where(x => x.Attribute("name").Value.Equals("country")).SingleOrDefault().Elements("country");
            areaNode = battleXml.Element("battle").Elements("list").Where(x => x.Attribute("name").Value.Equals("area")).SingleOrDefault().Elements("area");

            foreach (XElement country in countryNode)
            {
                Country tempCountry = new Country(country);
                if (!countryList.Exists(i => i.name.Equals(tempCountry.name)))
                {
                    countryList.Add(tempCountry);
                }
                else
                {
                    errors = true;
                    errorMessage += "國家名稱: \"" + tempCountry.name + "\" 重複出現！\n";
                }
            }
            foreach (XElement area in areaNode)
            {
                Area tempArea = new Area(area);
                if (!areaList.Exists(i => i.id == tempArea.id))
                {
                    areaList.Add(tempArea);
                }
                else
                {
                    errors = true;
                    errorMessage += "地塊ID: \"" + tempArea.id + "\" 重複出現！\n";
                }
            }

            return errorMessage;
        }
    }
}
