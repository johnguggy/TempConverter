using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TempConverter.Business;


namespace TempConverter.Web
{
    public partial class ConversionApp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void Btn1ClickHere_Click(object sender, EventArgs e)
        //{
        //    var Fahrenheit = new ConvertLibrary();
        //    int TempC = Int32.Parse(tbTempC.Text);
        //    int Answer = Fahrenheit.ConvertCtoF(TempC);
        //    tbTempF.Text = Answer.ToString();
        //}

        protected void btn2ClickHere_Click(object sender, EventArgs e)
        {
            var Celsius = new ClassLibrary();
            int TempF = Int32.Parse(tbTempF.Text);
            int Answer = Celsius.ConvertFtoC(TempF);
            tbTempC.Text = Answer.ToString();
        }

        protected void btn1ClickHere_Click(object sender, EventArgs e)
        {
            var Fahrenheit = new ClassLibrary();
            int TempC = Int32.Parse(tbTempC.Text);
            int Answer = Fahrenheit.ConvertCtoF(TempC);
            tbTempF.Text = Answer.ToString();
        }
    }
}