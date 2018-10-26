using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using TempConverter.Business;

namespace TempConverter.WS
{
    /// <summary>
    /// Summary description for TempConverterWS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class TempConverterWS : System.Web.Services.WebService
    {

        [WebMethod]
        public int TemperatureTOC(int TempC)
        {
            var Celsius = new ClassLibrary();
            return Celsius.ConvertFtoC(TempC);
        }

        [WebMethod]
        public int TemperatureTOF(int TempF)
        {
            var Fahrenheit = new ClassLibrary();
            return Fahrenheit.ConvertCtoF(TempF);
        }
    }
}
