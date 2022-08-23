using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;

namespace MovieStore.Classes
{
    public class Emailer
    {
        public Emailer(string s, string r, string sj, string b)
        {
            Sender = s;
            Receiver = r;
            Subject = sj;
            Body = b;
        }
       
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public void CreateMessage()
        {
            MailMessage mail = new MailMessage("bobbob1234519@yahoo.com", Receiver, Subject,Body);
            mail.IsBodyHtml = true;
            SmtpClient client = new SmtpClient("smtp.mail.yahoo.com");
         
            client.Port = 465;
            client.Credentials = new System.Net.NetworkCredential("bobbob1234519@yahoo.com", "heckyeah123");
            client.EnableSsl = true;
            client.Send(mail);
        }
        

             

               


      
    }
}
