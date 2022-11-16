using System;
namespace TrainingDemos
{
    public  delegate void NotifiyUser();
    public class Events
    {
        public void NotifyUsers()
        {
            User1 user1 = new User1();
            User2 user2 = new User2();

            NotificationService notificationService = new NotificationService();
            notificationService.notifyUserEvent += user1.User1Notification;
            notificationService.notifyUserEvent += user2.User2Notification;


            notificationService.NotifyUsers();
        }
        
    }

    public class NotificationService
    {
        public event NotifiyUser notifyUserEvent;
        // Can be done by delegate instance as well
        //public Notifiy notifyUserEvent


        public void NotifyUsers()
        {
            if(notifyUserEvent != null)
            {
                notifyUserEvent.Invoke(); //notifyUserEvent(); Publisher
            }
        }
    }

    class User1
    {
        public void User1Notification()
        {
            Console.WriteLine("Event received by user1");
        }
    }

    class User2
    {
        public void User2Notification()
        {
            Console.WriteLine("Event received by user2");
        }
    }


}

