namespace Notification;
using System.Threading;
public static class PostNotificationService
{
    public static void NotificationComplete(IAsyncResult itFar)
    {
        Console.WriteLine("NotificationComplete() invoked on thread {0}.", Thread.CurrentThread.ManagedThreadId);
        Console.WriteLine("Your Notification is complete");
    }
}
