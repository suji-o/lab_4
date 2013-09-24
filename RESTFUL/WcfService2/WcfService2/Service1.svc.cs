using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
         [WebInvoke(Method="GET",ResponseFormat=WebMessageFormat.Json,UriTemplate="add/{x}/{y}")]
         public int add(string x,string y)
         {
             return int.Parse(x) + int.Parse(y);
         }
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "sub/{x}/{y}")]
        public int sub(string x,string y)
        {
            return int.Parse(x) - int.Parse(y);
        }
       [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "mul/{x}/{y}")]
        public int mul(string x,string y)
        {
            return int.Parse(x) * int.Parse(y);
        }
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json, UriTemplate = "div/{x}/{y}")]
        public int div(string x,string y)
        {
            return int.Parse(x) / int.Parse(y);
        }

    }
}
