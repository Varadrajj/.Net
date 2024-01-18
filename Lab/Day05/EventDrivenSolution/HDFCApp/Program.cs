using Banking;
using Notification;
using Taxation;
using System.Threading;

Account ac = new Account();
ac.Balance = 10000;
ac.deposit(6000);
float CurrentBalance = ac.Balance;
Console.WriteLine("Current Balance is : " + CurrentBalance);

// NotificationService.sendEmail("Abhishek", "Your Salary is Deposited...");
// TaxationService.payIncomeTax(5000);

// TaxOperation proxy = new TaxOperation(TaxationService.payIncomeTax);
// proxy(6000);

//Atach the functions to delegates...
NotificationOperation proxyEmailSender = new NotificationOperation(NotificationService.sendEmail);
NotificationOperation proxySMSSender = new NotificationOperation(NotificationService.sendSms);
NotificationOperation proxyWASender = new NotificationOperation(NotificationService.sendWhatsApp);

NotificationOperation proxy = null;

//Chaining of delegates
proxy += proxyEmailSender;
proxy += proxySMSSender;
proxy += proxyWASender;

proxy("Abhi", "How Are You!!!");

proxy -= proxyEmailSender;
proxy -= proxyWASender;

proxy("Varad", "Thank You...");

proxy.Invoke("Reeya", "Welcome...");

//Asynchronous Call or Non-Blocking call
// IAsyncResult iResult = proxy.BeginInvoke("Sarang", "Thank You...", new AsyncCallback(PostNotificationService.NotificationComplete), null);
// proxy.EndInvoke(iResult);

Thread currentThread = Thread.CurrentThread;
int ThreadId = currentThread.ManagedThreadId;
Console.WriteLine("The Main Method is Running in Thread Id: " + ThreadId);
Console.WriteLine("The Main Method is Running on Thread Priority: " + currentThread.Priority);