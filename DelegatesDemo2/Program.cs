using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemo2
{
    delegate void Alert(string msg);
    internal class Program
    {
        public static void Main()
        {
            Account A1 = new Account { AccountNo = 111, Balance = 5000 };
           // A1.alert += Notification.SendEmail;//static
           A1.Subscribe(Notification.SendEmail); //method call
            Notification n = new Notification();
            //A1.alert += n.SendSms;
            //A1.alert += n.Whatsapp;
            A1.Subscribe(n.SendSms);//method call
            A1.Subscribe(n.Whatsapp); 

            // A1.alert("hi");

            A1.Deposit(1000);
            Console.WriteLine("Current Balance:" + A1.Balance);
            A1.Withdraw(1000);
            Console.WriteLine("Current Balance:"+A1.Balance);
        }
    }
    class Account
    {
       /* public event */ private Alert alert = null;// or make it as private and create methods inside the classs
        public int AccountNo { get; set; }
        public int Balance { get; set; }
        public void Subscribe(Alert alert)
        {
            this.alert += alert;
        }
        public void UnSubscribe(Alert alert)
        {
            this.alert -= alert;
        }
        public void Deposit(int amt)
        {
            Balance += amt;
           // Notification.SendEmail("Deposited " + amt + " into account " + AccountNo);
           if(alert != null)
                alert("Deposited " + amt + " into account " + AccountNo);
        }
        public void Withdraw(int amt)
        {
            Balance -= amt;
            //Notification.SendEmail("Withdrawn " + amt + " from account " + AccountNo);
            if (alert != null)
                alert("Withdrawn " + amt + " from account " + AccountNo);
        }
    }

    class Notification
    {
        public static void SendEmail(string msg)
        {
            Console.WriteLine("Mail:" + msg);

            //System.Net.Mail.SmtpClient smtpClient = new System.Net.Mail.SmtpClient();
            //smtpClient.Host = "smtp.gmail.com";
            //smtpClient.Port = 587;
            //smtpClient.Credentials = null;

            //System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage("from-email","to-email");
            //message.Subject = "Subject";
            //message.Body = "Message Body";
            //message.Attachments.Add(null);
            //smtpClient.Send(message);
        }
        public void SendSms(string msg)
        {
            Console.WriteLine("SMS:" + msg);
        }
        public void Whatsapp(string msg)
        {
            Console.WriteLine("Whatsapp:" + msg);
        }
    }
}
