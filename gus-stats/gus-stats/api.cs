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

        abstract protected string ApiTestAddr { get;}
        /// <summary>
        /// konstruktor klasy API. wywołuje sobie na start metodę connect, żeby sprawdzić czy gus przypadkiem nie zmienił adresu
        /// przy okazji nadając sobie właściwość "status" na true jeśli dał radę pobrać przykładowe informacje
        /// </summary>
        public Api()
        {
            status = Connect();
        }
            
        protected bool Connect()
        {
            try
            {
                //Creating the HttpWebRequest
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

        private string[,] ReadResponse(XmlDocument xml,string rootName)
        {
            XmlElement root = xml.DocumentElement;
            XmlNodeList nodes = root.SelectNodes("/"+rootName+"/results");
            string[,] nodesContents;
            nodesContents = new string[nodes.Count,3];
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

        private string buildRequestUrl(string requestString)
        {
            string url;
            url = ApiTestAddr + requestString;
            return url;
        }

        public string request(string requestString, string rootName)
    }
}
