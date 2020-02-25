using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace WebApplication
{
    public class Class1
    {
        public void Test()
        {
            HttpContext.Current.Session["TEST2"] = "TEST_CLASS";
        }
    }
}