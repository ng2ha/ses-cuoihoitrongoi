using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net;
using System.IO;
using System.Collections.Generic;

namespace SES.CMS
{
    public partial class FTP : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            getFileList("ftp://ses.vn", "ses", "123vnn");
        }
        private void getFileList(string FTPAddress, string username, string password)
        {
            List<string> files = new List<string>();

            try
            {

                //Create FTP request
                FtpWebRequest request = (FtpWebRequest)FtpWebRequest.Create(FTPAddress);

                request.Method = WebRequestMethods.Ftp.ListDirectory;
                request.Credentials = new NetworkCredential(username, password);
                request.UsePassive = true;
                request.UseBinary = true;
                request.KeepAlive = false;


                FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                Stream responseStream = response.GetResponseStream();
                StreamReader reader = new StreamReader(responseStream);

                while (!reader.EndOfStream)
                {
                    
                    files.Add(reader.ReadLine());
                }

                //Clean-up
                reader.Close();
                responseStream.Close(); //redundant
                response.Close();
            }
            catch (Exception ex)
            {
                Response.Write("Loi: " + ex.Message);
            }



            //If the list was successfully received, display it to the user
            //through a dialog
            if (files.Count != 0)
            {
                foreach (string file in files)
                {
                    ListBox1.Items.Add(file);
                }

            }
        }
    }
}
