namespace Notification;
public static class NotificationService
{
    public static void sendSms(string to, string content)
    {
        Console.WriteLine("Sms Is sent to..." + to + " that " + content);
    }
    public static void sendEmail(string to, string content)
    {
        Console.WriteLine("Email is sent to..." + to + " that " + content);
    }
    public static void sendWhatsApp(string to, string content)
    {
        Console.WriteLine("WhatsApp is sent to..." + to + " that " + content);
    }
}
