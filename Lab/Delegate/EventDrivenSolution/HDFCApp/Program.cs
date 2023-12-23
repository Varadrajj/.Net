using System.Net;
using Banking;
using notification;
using Taxation;

Account acc = new Account();
acc.Balance = 500000;
acc.Deposit(200000);
// float currentBalance = acc.Balance;
Console.WriteLine("Current Balance is= " + acc.Balance);

//Direct calling
//Sychronous Calling
// NotificationService.SendEmail("Varadraj", "Your Salary is deposited.");
// NotificationService.SendSMS("Varadraj", "Your Salary is deposited.");
// NotificationService.SendWhatsUp("Varadraj", "Your Salary is deposited.");

// TaxationService.PayIncomeTax(10000);

//Asynchronous Calling

//Attaching functions to delegates
NotificationOperation EmailSender = new NotificationOperation(NotificationService.SendEmail);
NotificationOperation SMSsender = new NotificationOperation(NotificationService.SendSMS);
NotificationOperation WhatsUpSender = new NotificationOperation(NotificationService.SendWhatsUp);
// SMSsender("Varadraj", "Your Salary is deposited.");

// NotificationOperation proxy = null;
//Chaining
// proxy += EmailSender;
// proxy += SMSsender;
// proxy += WhatsUpSender;

// proxy("Varadraj", "Your Salary is Deposited.");

//Dechaining
// proxy += EmailSender;
// proxy += SMSsender;
// proxy += WhatsUpSender;
// proxy("Pranav", "How Are you Bro.");
// proxy.Invoke("Pranav", "How Are you Bro.");

// IAsyncResult iresult = proxy.BeginInvoke("Pranav", "How Are you Bro.", null, null);
// proxy.EndInvoke(iresult);

Account acc1 = new Account();
acc1.Balance = 700000;
// acc1.Deposit(10000);
acc1.overBalance += TaxationService.PayIncomeTax;
acc1.overBalance += TaxationService.PayServiceTax;

acc1.underBalance += NotificationService.SendEmail;
acc1.underBalance += NotificationService.SendSMS;
acc1.underBalance += NotificationService.SendWhatsUp;

acc1.Deposit(200000);
// acc1.Withdraw(600000);