using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace gus_stats
{
    abstract class Api
    {
        /// <summary>
        /// bool, który trzyma status połączenia z API
        /// </summary>
        public bool status;

        abstract protected string XmlLoadAddrPrefix { get; }
        abstract protected string XmlLoadAddrSuffix { get; }
        protected string XmlLoadAddr
        {
            get
            {
                return XmlLoadAddrPrefix + XmlLoadAddrSuffix;
            }
        }
        abstract protected string XmlNodeStructure { get; }
        abstract protected string ApiTestAddr { get; }

        protected string GetXmlNodeName()
        {
            return "name";
        }
        protected string GetXmlNodeId()
        {
            return "id";
        }


        /// <summary>
        /// konstruktor klasy API. wywołuje sobie na start metodę connect, żeby sprawdzić czy gus nie zmienil adresu
        /// przy okazji nadając sobie właściwość "status" na true jeśli dał radę pobrać przykładowe informacje
        /// </summary>
        public Api()
        {
            status = Connect();
        }

        /// <summary>
        /// Weryfikacja statusu polaczenia do konkretnego API
        /// </summary>
        /// <returns>status API</returns>
        protected bool Connect()
        {
            try
            {
                //Creating the HttpWebRequest, zmienna ApiTestAddr przekazywana z klasy konkretnego API
                HttpWebRequest request = WebRequest.Create(ApiTestAddr) as HttpWebRequest;
                //Setting the Request method HEAD, you can also use GET too.
                request.Method = "GET";
                //Getting the Web Response.
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                //Returns TRUE if the Status code == 200
                response.Close();
                //TODO: kiedys moze zrobic obsluge tych status codow
                //return (response.StatusCode == HttpStatusCode.OK);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public abstract string[] GetData();

        /// <summary>
        /// zwraca surowego xmla, trzeba go potem rozszyfrować
        /// </summary>
        /// <param name="requestString">same argumenty zapytania, bez adresu api</param>
        /// <returns>surowy xml</returns>
        private XmlDocument RequestToApi(string requestString)
        {
            string requestUrl = buildRequestUrl(requestString);
            XmlDocument xml = new XmlDocument();
            xml.Load(requestUrl);
            return xml;
        }

        /// <summary>
        /// Buduje pełny adres do API (adres api + sam request)
        /// </summary>
        /// <param name="requestString"> sam request </param>
        /// <returns> zwraca pełny adres do odpytania API </returns>
        private string buildRequestUrl(string requestString)
        {
            string url;
            url = ApiTestAddr + requestString;
            return url;
        }

        private string[,] ReadResponse(XmlDocument xml, string rootName)
        {
            XmlElement root = xml.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("/" + rootName + "/results");
            string[,] nodesContents;
            nodesContents = new string[nodes.Count, 3];
            int nodesIndex = 0;
            foreach (XmlNode node in nodes)
            {
                nodesContents[nodesIndex, 0] = node["id"].InnerText;
                if (node.SelectSingleNode("name") != null)
                {
                    nodesContents[nodesIndex, 1] = node["name"].InnerText;
                }
                else
                {
                    nodesContents[nodesIndex, 1] = node["n1"].InnerText;
                }
                if (node.SelectSingleNode("values") != null)
                {
                    XmlNodeList valuesNodes = node.SelectNodes("values");
                    foreach (XmlNodeList valueNode in valuesNodes)
                    {

                    }
                }
                nodesIndex++;

            }
            return nodesContents;
        }

        /// <summary>
        /// wykonuje request do api
        /// </summary>
        /// <param name="requestString"></param>
        /// <param name="rootName"></param>
        /// <returns></returns>
        public string getValues(string requestString)
        {
            string result = "";
            XmlDocument doc = new XmlDocument();
            doc.Load(XmlLoadAddrPrefix+requestString);
            XmlNodeList nodes = doc.DocumentElement.SelectNodes("/singleVariableData/results/unitData");
            foreach (XmlNode node in nodes)
            {
                result += "+"+node.SelectSingleNode("name").InnerText+ "\r\n";
                XmlNodeList miniNodes = node.SelectNodes("values/yearVal");
                foreach (XmlNode miniNode in miniNodes)
                {
                    result += "-"+ miniNode.SelectSingleNode("year").InnerText + " - ";
                    result += miniNode.SelectSingleNode("val").InnerText + "\r\n";
                }

            }

            return result;
        }


        /// <summary>
        /// metoda mozna wywolac zarowno z perametrami jak i bez parametrow. 
        /// defaultowo daje jako odpowiedz liste topicow z api.
        /// jako parametr mozemy dac adr%costamcostam=costam i wtedy do urla zapytania doklei sie costamcostam=costam
        /// dodatkowo jako inny/dodatkowy parametr mozemy napisac name%n1, wtedy metoda nie bedzie szukac node'a o nazwie name tylko o nazwie n1
        /// (przydatne do najnizszych poziomow API)
        /// 
        /// z parametrów korzystam, ponieważ jesli uzylbym przeladowanej metody, to podczas dalszych prac nad programem nalezalo by
        /// modyfikowac kazda definicje klasy, aby naniesc nawet najprostrza poprawke. lepiej wiec bylo mi uzyc parametrow, poniewaz
        /// oferuja identyczne korzysci co przeladowanie, czyli:
        /// nieobowiazkowe argumenty
        /// </summary>
        /// <param name="parameters">adr%VALUE,name%VALUE</param>
        /// <returns></returns>
        private string[,] GetTopics(params string[] parameters)
        {
            XmlDocument doc = new XmlDocument();
            bool useDefaultClassLoadAddr = true;
            bool useAltName = false;
            bool useAltNode = false;
            string customLoadAddr = "";
            string customName = "";
            string customNode = "";
            foreach (string parameter in parameters)
            {
                string[] parameterString = new string[parameter.Split('%').Length];
                string[] parameterSplited = parameter.Split('%');
                string prefixParameter = parameterSplited[0]; // czy to jest adr czy moze nazwa czy id
                string suffixParameter = parameterSplited[1]; // wartosc
                switch (prefixParameter)
                {
                    case "adr":
                        useDefaultClassLoadAddr = false;
                        customLoadAddr = XmlLoadAddrPrefix + suffixParameter;
                        break;
                    case "name":
                        useAltName = true;
                        customName = suffixParameter;
                        break;
                    case "node":
                        useAltNode = true;
                        customNode = suffixParameter;
                        break;
                }

            }
            if (useDefaultClassLoadAddr)
            {
                doc.Load(XmlLoadAddr);
            }
            else
            {
                doc.Load(customLoadAddr);
            }
            if (useAltNode)
            {
                XmlNodeList nodes = doc.DocumentElement.SelectNodes(customNode);
                string[,] topicsArr = new string[nodes.Count, 2]; //tablica zawierajaca topiki
                int i = 0;
                foreach (XmlNode node in nodes)
                {
                    topicsArr[i, 0] = node.SelectSingleNode(GetXmlNodeId()).InnerText;
                    if (useAltName)
                    {
                        topicsArr[i, 1] = node.SelectSingleNode(customName).InnerText;
                        if (customName=="n1")
                        {
                            if (node.SelectSingleNode("n2")!=null)
                            {
                                topicsArr[i, 1] += " "+node.SelectSingleNode("n2").InnerText;
                            }
                        }
                    }
                    else
                    {
                        topicsArr[i, 1] = node.SelectSingleNode(GetXmlNodeName()).InnerText;
                    }

                    i++;
                }
                return topicsArr;
            }
            else
            {
                XmlNodeList nodes = doc.DocumentElement.SelectNodes(XmlNodeStructure);
                string[,] topicsArr = new string[nodes.Count, 2]; //tablica zawierajaca topiki
                int i = 0;
                foreach (XmlNode node in nodes)
                {
                    topicsArr[i, 0] = node.SelectSingleNode(GetXmlNodeId()).InnerText;
                    if (useAltName)
                    {

                        topicsArr[i, 1] = node.SelectSingleNode(customName).InnerText;
                    }
                    else
                    {
                        topicsArr[i, 1] = node.SelectSingleNode(GetXmlNodeName()).InnerText;
                    }

                    i++;
                }
                return topicsArr;
            }
        }

        /*
        public string[] getVariableData(string endPoint)
        {
            XmlDocument doc = new XmlDocument();
            XmlNodeList nodes = doc.DocumentElement.SelectNodes(XmlNodeStructure);
            return dataArray;
        }*/
        /// <summary>
        /// ponizsze metody definitywnie do refaktora, bo sie powtazaja
        /// pomysl: moze jakos przekazac czy to name czy to id do argumentu metody
        /// </summary>
        /// <returns></returns>
        public string[] getTopicsNames(params string[] parameters)
        {
            bool customTopicAdress = false;
            string[] customLoadAddr = new string[parameters.GetLength(0)];
            if (parameters.GetLength(0) > 0)
            {
                customTopicAdress = true;
                customLoadAddr = parameters;
            }
            if (customTopicAdress)
            {
                string[,] topics = GetTopics(customLoadAddr);
                string[] topicNames = new string[topics.GetLength(0)];
                for (int i = 0; i < topics.GetLength(0); i++)
                {
                    topicNames[i] = topics[i, 1];
                }
                return topicNames;
            }
            else
            {
                string[,] topics = GetTopics();
                string[] topicNames = new string[topics.GetLength(0)];
                for (int i = 0; i < topics.GetLength(0); i++)
                {
                    topicNames[i] = topics[i, 1];
                }
                return topicNames;
            }
            

        }
        


        public string[] getTopicsIds(params string[] parameters)
        {

            bool customTopicAdress = false;
            string[] customLoadAddr = new string[parameters.GetLength(0)];
            if (parameters.GetLength(0)>0)
            {
                customTopicAdress = true;
                customLoadAddr = parameters;
            }
            if (customTopicAdress)
            {
                string[,] topics = GetTopics(customLoadAddr);
                string[] topicIds = new string[topics.GetLength(0)];
                // do refactora - nie wiem dlaczego for ponizej ifa nie widzi zmiennej topics
                for (int i = 0; i < topics.GetLength(0); i++)
                {
                    topicIds[i] = topics[i, 0];
                }
                return topicIds;
            }
            else
            {
                string[,] topics = GetTopics();
                string[] topicIds = new string[topics.GetLength(0)];
                // do refactora - nie wiem dlaczego for ponizej ifa nie widzi zmiennej topics
                for (int i = 0; i < topics.GetLength(0); i++)
                {
                    topicIds[i] = topics[i, 0];
                }
                return topicIds;
            }
        }




        public string translateNameToId(string name)
        {
            string id = null;
            string[,] topics = GetTopics();
            for (int i = 0; i < topics.GetLength(0); i++)
            {
                if (name == topics[i, 1])
                {
                    id = topics[i, 0];
                }
            }
            return id;
        }

        /// <summary>
        /// przeladowana funkcja
        /// </summary>
        /// <param name="name"></param>
        /// <param name="customparams"></param>
        /// <returns></returns>
        public string translateNameToId(string name,string[] customparams)
        {
            string id = null;
            string[,] topics = GetTopics(customparams);
            for (int i = 0; i < topics.GetLength(0); i++)
            {
                if (name == topics[i, 1])
                {
                    id = topics[i, 0];
                }
            }
            return id;
        }

    }
}
