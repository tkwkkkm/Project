using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class About : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ClassLibrary1.Class1 class1 = new ClassLibrary1.Class1();
            ClassLibrary2.Class1 class2 = new ClassLibrary2.Class1();
            ClassLibrary3.Class1 class3 = new ClassLibrary3.Class1();

            Response.Write(Session["TEST"].ToString());
            Response.Write(Session["TEST2"].ToString());
            Response.Write(class1.Test());
            Response.Write(class2.Test());
            Response.Write(class3.Test());
        }
    }
}
