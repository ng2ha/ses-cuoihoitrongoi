using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Xml.Linq;
using SES.CMS.DO;
using SES.CMS.BL;

namespace SES.CMS
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Application["visitors_online"] = 0;

        }

        protected void Session_Start(object sender, EventArgs e)
        {
                string ip = Request.ServerVariables["REMOTE_ADDR"].Trim();
                DateTime moment = new cmsCounterBL().getTimeNow();
                if (Session["UID"]==null)
                {
                    cmsCounterDO counterDO = new cmsCounterDO();
                    counterDO.sIP = ip;
                    counterDO.tDate = moment;

                    cmsCounterBL counterDL = new cmsCounterBL();
                    counterDL.Insert(counterDO);
                }
                Application.Lock();
                Application["visitors_online"] = Convert.ToInt32(Application["visitors_online"]) + 1;
                Application.UnLock();
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {
            Application.Lock();
            Application["visitors_online"] = Convert.ToUInt32(Application["visitors_online"]) - 1;
            Application.UnLock();
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Application["visitors_online"] = 0;
        }
    }
}