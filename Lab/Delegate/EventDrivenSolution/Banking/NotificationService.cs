namespace notification;

public static class NotificationService
{

    public static void SendEmail(string to, string content)
    {
        Console.WriteLine("Email is sent to " + to + " that " + content);
    }

    public static void SendSMS(string to, string content)
    {
        Console.WriteLine("SMS is sent to " + to + " that " + content);
    }

    public static void SendWhatsUp(string to, string content)
    {
        Console.WriteLine("Whats Up message is sent to " + to + " that " + content);
    }
}