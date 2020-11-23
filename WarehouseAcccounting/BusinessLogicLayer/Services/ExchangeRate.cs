using System.Globalization;
using System.Xml;

namespace BusinessLogicLayer
{
    public class ExchangeRate
    {
        private  string  url = "https://api.privatbank.ua/p24api/pubinfo?exchange&coursid=5";
        

        public ExchangeRate()
        {
        }

        private string GetValues(string currencyType)
        {
            XmlTextReader reader = new XmlTextReader(url);
            while (reader.Read())
            {
                switch (reader.NodeType)
                {
                    case XmlNodeType.Element:
                        if (reader.Name == "exchangerate")
                        {
                            if (reader.HasAttributes)
                            {
                                while (reader.MoveToNextAttribute())
                                {
                                    if (reader.Name == "ccy")
                                    {
                                        if (reader.Value == currencyType)
                                        {
                                            reader.MoveToElement();
                                            return reader.ReadOuterXml();

                                        }
                                    }


                                }
                            }
                        }

                        break;
                }
            }
            return null;
        }

        public decimal SetValues(string currencyType)
        {
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(GetValues(currencyType));

            XmlNodeList xmlNodeList = xmlDocument.SelectNodes("exchangerate");
            foreach (XmlNode n in xmlNodeList)
            {
                return decimal.Parse(n.SelectSingleNode("@sale").Value, CultureInfo.InvariantCulture);
            }
            return 0;
        }
    }
}
