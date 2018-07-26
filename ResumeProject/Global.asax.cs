using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ResumeProject
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Init(object sender, EventArgs e)
        {
            StreamWriter logouput = new StreamWriter(HttpRuntime.AppDomainAppPath + "\\Resources\\GlobalApp.txt", true);
            logouput.WriteLine(DateTime.Now.ToString() + ": " + "Application Init");
            logouput.Close();



        }




        protected void Application_Start(object sender, EventArgs e)
        {
            StreamWriter logouput = new StreamWriter(HttpRuntime.AppDomainAppPath + "\\Resources\\GlobalApp.txt", true);
            logouput.WriteLine(DateTime.Now.ToString() + ": " + "Application started");
            logouput.Close();
                          
            

        }


        protected void Application_End(object sender, EventArgs e)
        {
            StreamWriter logouput = new StreamWriter(HttpRuntime.AppDomainAppPath + "\\Resources\\GlobalApp.txt", true);
            logouput.WriteLine(DateTime.Now.ToString() + ": " + "ApplicationEnded");
            logouput.Close();


        }



        protected void Session_Start (object sender, EventArgs e)
        {
            StreamWriter logouput = new StreamWriter(HttpRuntime.AppDomainAppPath + "\\Resources\\GlobalApp.txt", true);
            logouput.WriteLine(DateTime.Now.ToString() + ": " + "Session_Started");
            logouput.Close();


        }

        protected void Session_End(object sender, EventArgs e)
        {
            StreamWriter logouput = new StreamWriter(HttpRuntime.AppDomainAppPath + "\\Resources\\GlobalApp.txt", true);
            logouput.WriteLine(DateTime.Now.ToString() + ": " + "Session Ended");
            logouput.Close();


        }


    }


}