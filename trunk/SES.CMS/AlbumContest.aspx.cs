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
using SES.CMS.BL;
using SES.CMS.DO;
using System.Net.Mail;

namespace SES.CMS
{
    public partial class AlbumContest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.Title = "Đăng kí tham dự cuộc thi Ảnh";
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
                string AlbumFileName = UploadFile(FileUpload1);
                string body = "";
                body = body + "<br/> Họ tên: " + txtName.Value;
                body = body + "<br/> Địa chỉ: " + txtAddress.Value;
                body = body + "<br/> Số điện thoại: " + txtTel.Value;
                body = body + "<br/> Email: " + txtEmail.Value;
                body = body + "<br/><b> Mô tả Album: </b>";
                body = body + "<br/>=====================<br/> " + txtOther.Value;
                string url = Request.Url.ToString();
                url = url.Replace("AlbumContest.aspx", "");


                body = body + "<br/>=====================<br/> " + "<br/> Album link:  http://cuoihoitrongoi.com.vn/Media/" + AlbumFileName;

                Ultility.Alert(SendMail(txtName.Value, "Đăng kí tham dự cuộc thi Ảnh từ Website", body, new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, true, true), "/Default.aspx");
            }
        }

        private string UploadFile(FileUpload fulImages)
        {
            if (!string.IsNullOrEmpty(fulImages.FileName))
            {

                string originFilename = fulImages.FileName.Substring(0, fulImages.FileName.LastIndexOf("."));
                string FileName = string.Format("{0}{1}",Ultility.Change_AVNohtml(originFilename) + "-" + DateTime.Now.ToString("ddMMyyyyhhmmss"), fulImages.FileName.Substring(fulImages.FileName.LastIndexOf(".")));
                string SaveLocation = string.Format("{0}\\{1}", Server.MapPath("~/Media/"), FileName);
                fulImages.SaveAs(SaveLocation);
                return FileName;
            }
            return string.Empty;
        }

        public string SendMail(string Name, string subject, string body, string to, bool isHtml, bool isSSL)
        {
            try
            {
                using (MailMessage mail = new MailMessage())
                {
                    mail.From = new MailAddress(to, Name);
                    mail.ReplyTo = new MailAddress(to, Name);
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
                    mail.From = new MailAddress(new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, "Công ty TNHH Quang Dũng - Đăng ký Tham dự Cuộc thi ảnh");
                    mail.ReplyTo = new MailAddress(new sysConfigBL().Select(new sysConfigDO { ConfigID = 4 }).ConfigValue, "Công ty TNHH Quang Dũng - Đăng ký Tham dự Cuộc thi ảnh");
                    mail.To.Add(txtEmail.Value);
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

    }
}
