using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Net.Configuration;
using System.Net.Mail;
using System.Configuration;
using SES.CMS.BL;
using SES.CMS.DO;

namespace SES.CMS
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Liên hệ với chúng tôi";
            lblThongTin.Text = (new sysConfigBL().Select(new sysConfigDO { ConfigID = 8 })).ConfigValue;
        }
        public static String FormAddress
        {
            get
            {
                SmtpSection cfg = (SmtpSection)ConfigurationManager.GetSection
                    ("system.net/mailSettings/smtp");
                return cfg.Network.UserName;
            }
        }
        public string SendMail(string Name, string subject, string body, string to, bool isHtml, bool isSSL)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(txtGroommail.Value, "Công ty TNHH Quang Dũng - Thư Liên hệ");
                    mail.ReplyTo = new MailAddress(txtGroommail.Value, txtGroomName.Value);
                    mail.To.Add(to);
                    mail.Subject = subject;
                    mail.Body = body;
                    mail.IsBodyHtml = isHtml;
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = isSSL;
                    client.Credentials = new System.Net.NetworkCredential("cuoihoitrongoimailsystem@gmail.com", "@@123vnn");
                    client.Send(mail);


                    

                }

                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, "Công ty TNHH Quang Dũng - Thư Liên hệ");
                    mail.ReplyTo = new MailAddress(new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, "Công ty TNHH Quang Dũng - Thư Liên hệ");
                    mail.To.Add(txtGroommail.Value);
                    mail.Subject = subject;
                    mail.Body = "Gửi mail thành công, cảm ơn bạn đã liên hệ! Chúng tôi sẽ trả lời các ý kiến của bạn sớm nhất.";
                    mail.IsBodyHtml = isHtml;
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.EnableSsl = isSSL;
                    client.Credentials = new System.Net.NetworkCredential("cuoihoitrongoimailsystem@gmail.com", "@@123vnn");
                    client.Send(mail);
                }
            }
            catch (SmtpException ex)
            {
                return " Lỗi gửi email " + ex.Message;
            }
            
            return "Gửi mail thành công, cảm ơn bạn đã liên hệ! Chúng tôi sẽ trả lời các ý kiến của bạn sớm nhất.";
        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            ccJoin.ValidateCaptcha(txtCaptcha.Value);
            if (!ccJoin.UserValidated)
            {
                Ultility.Alert("Bạn nhập không đúng mã bảo mật.");
                return;
            }
            else
            {
                string body = "";
                body = body + "<br/> Họ tên: " + txtGroomName.Value;
                body = body + "<br/> Địa chỉ: " + txtGroomAddress.Value;
                body = body + "<br/> Số điện thoại: " + txtGroomTel.Value;
                body = body + "<br/> Email: " + txtGroommail.Value;
                body = body + "<br/><b> Yêu cầu khác: </b>";
                body = body + "<br/><br/>: " + txtOther.Value;
                Ultility.Alert(SendMail(txtGroomName.Value, "Liên hệ từ Website", body, new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, true, true), "/Default.aspx");
            }
        }
    }
}
