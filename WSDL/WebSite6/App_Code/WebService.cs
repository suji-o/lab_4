using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService {

    public WebService () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod(Description = "addition")]
    public int add(string x, string y)
    {
        return int.Parse(x) + int.Parse(y);
    }
    [WebMethod(Description = "subtraction")]
    public int sub(string x, string y)
    {
        return int.Parse(x) - int.Parse(y);
    }
    [WebMethod(Description = "multiplication")]
    public int mul(string x, string y)
    {
        return int.Parse(x) * int.Parse(y);
    }
    [WebMethod(Description = "division")]
    public int div(string x, string y)
    {
        return int.Parse(x) / int.Parse(y);
    }
}
