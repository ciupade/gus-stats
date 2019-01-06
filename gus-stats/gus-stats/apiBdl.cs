using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

using System.Windows.Forms;

namespace gus_stats
{
    class ApiBdl : Api
    {
        protected override string XmlLoadAddrPrefix => "http://bdl.stat.gov.pl/api/v1/";
        protected override string XmlLoadAddrSuffix => "subjects?lang=pl&format=xml&page=0&page-size=100";
        protected override string XmlNodeStructure => "/subjectList/results/subject";
        protected override string ApiTestAddr => "https://bdl.stat.gov.pl/api/v1/subjects?format=xml";

        override public string[] GetData()
        {
            string[] test = new string[5];
            test[0]="test";
            
            return test;
        }
    }
}
