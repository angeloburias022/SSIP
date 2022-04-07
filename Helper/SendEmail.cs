using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using SSIP.Models;

namespace SSIP.Helper
{
    public static class SendEmail
    {
        public static bool Send(Emailer emailer)
        {
            try
            {
 
                using (var businessDetails = new SmtpClient { 
                    Port = 587, 
                    Host = "smtp.gmail.com", 
                    EnableSsl = true, 
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential("rfbairconditioningservices@gmail.com", "r@f@3l091577"),
                })
                {
                    using (var mssgDetails = new MailMessage())
                    {
                        mssgDetails.From = new MailAddress("rfbairconditioningservices@gmail.com");
                        mssgDetails.To.Add(emailer.Receiver);
                        mssgDetails.Subject = emailer.Subject;
                        mssgDetails.IsBodyHtml = true;
                        mssgDetails.Body = emailer.Body;
                        mssgDetails.Attachments.Add(new Attachment(emailer.Attachments));

                        businessDetails.Send(mssgDetails);
                        businessDetails.Dispose();
                    }
                    return true;
                }         
            }
            catch (Exception error)
            {
                error.ToString();
            }
            return false;
        }
    }
}
