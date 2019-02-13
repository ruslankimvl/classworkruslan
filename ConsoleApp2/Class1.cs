using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public enum RequestType { SALES , SALESIMS,STORED,MOVING,GOODS_RECEIPT}
    public class Request
    {
        public RequestType RequestType { get; set; }
        public int Kunnr { get; set; }
        public int Bukrs { get; set; }
        public int Werks { get; set; }
        public DateTime Date1 { get; set; }
        public DateTime Date2 { get; set; }

        public void CreateRequest() {
            Request r = new Request()
               // Console.WriteLine()
                public string Url { get; private set; }

        public string GetJasonString()
        {
            string json = "";
        }
    }
        }

    }
}
