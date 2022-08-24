using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Net.Mail;
using System.Net;
using MovieStore.Models;

namespace MovieStore.Classes
{
    public class Emailer
    {
        public Emailer( string r, string sj, string b)
        {
            
            Receiver = r;
            Subject = sj;
            Body = b;
        }
       
       
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
        public static async Task CreateReciptEmail(UserDatum user, string items, int count, string total,UserPromos newpromo)
        {
            if (user.email != null)
            {
                string body;
                string Reciever = user.email;
                string subject = $"{user.Username} Recipt for {DateTime.Now}";
                if(newpromo != null)
                {
                    body = $"<h2>Thank you for your purchase {user.Username}!</h2><br> Below is your purchase summary.<br>" +
                    $"Items purchased:{count}  <br>" +
                    $"Title Names: {items} <br>" +
                    $"Total price: {total} <br>" +
                    $"Promo Code gained: {newpromo.Promoname} for {newpromo.PromoValue*100}% off a purchase of your choice!<br>" +
                    $"Have a great day,<br>" +
                    $"MovieStore";
                }
                else
                {
                    body = $"<h2>Thank you for your purchase {user.Username}<h2>!<br> below is your purchase summary.<br>" +
                    $"Items purchased:{count}  <br>" +
                    $"Title Names: {items} <br>" +
                    $"Total price: {total} <br>" +
                    $"have a great day,<br>" +
                    $"MovieStore";
                }
                
                var emailer = new Emailer(Reciever, subject, body);
                 await emailer.CreateMessage();
            }
        }
        public static async Task CreateSignupEmail(UserDatum user)
        {
            if (user.email != null)
            {

                string Reciever = user.email;
                string subject = $"{user.Username} Sign up confirmation ";
                string body = $"Hello {user.Username}, thanks for signing up for our movie store on {DateTime.Now}<br>" +
                    $" Enjoy this 50% discount code for your first purchase!<br>" +
                    $"Code: NewUser50 <br>" +                    
                    $"have a great day,<br>" +
                    $"MovieStore";
                var emailer = new Emailer(Reciever, subject, body);
                await emailer.CreateMessage();
            }
        }

        public async Task  CreateMessage()
        {
            MailMessage mail = new MailMessage(PrivateData.sender, Receiver, Subject,Body);
            mail.IsBodyHtml = true; 
            using (SmtpClient client = new SmtpClient("smtp-mail.outlook.com", 587))
            {
                client.EnableSsl = true;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential(PrivateData.sender, PrivateData.password);
                await client.SendMailAsync(mail);
            }
        }
        

             

               


      
    }
}
