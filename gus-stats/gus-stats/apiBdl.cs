using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace gus_stats
{
    class ApiBdl : Api
    {
        protected override string ApiTestAddr
        {
            get
            {
                return "https://bdl.stat.gov.pl/api/v1/subjects?format=xml";
            }
        }
        protected string apiTestAddr = "https://bdl.stat.gov.pl/api/v1/subjects?format=xml";

        override public string[] GetData()
        {
            string[] test = new string[5];
            test[0]="psiafaja";

            return test;
        }

        public string[] GetTopics()
        {
            HttpWebRequest request = WebRequest.Create("https://bdl.stat.gov.pl/api/v1/subjects?lang=pl&format=xml&page=0&page-size=100") as HttpWebRequest;
            //Setting the Request method HEAD, you can also use GET too.
            request.Method = "GET";
            //Getting the Web Response.
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;
            //Returns TRUE if the Status code == 200
            response.Close();
            return
        }

    }
}
