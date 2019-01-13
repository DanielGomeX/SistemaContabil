using SistemaContabil.Core.SharedKernel.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SistemaContabil.Core.SharedKernel.Notifications
{
    public class NotificationHandler : INotificationHandler
    {
        private readonly List<Notification> _notifications;

        public NotificationHandler()
        {
            _notifications = new List<Notification>();
        }

        public virtual List<Notification> GetNotifications()
        {
            return _notifications;
        }

        public void Handle(Notification message)
        {
            _notifications.Add(message);
            Console.ForegroundColor = ConsoleColor.Red;
        }

        public virtual bool HasNotifications()
        {
            return _notifications.Any();
        }
    }
}
