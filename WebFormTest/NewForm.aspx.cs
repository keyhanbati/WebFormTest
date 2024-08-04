using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormTest
{
    public partial class NewForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Request.QueryString["EmpID"];
            string name = Request.QueryString["EmpName"];
            string age = Request.QueryString["EmpAge"];
            Label1.Text = $"Id:{id} Name:{name} Age:{age}"; 
            
        }
    }
}