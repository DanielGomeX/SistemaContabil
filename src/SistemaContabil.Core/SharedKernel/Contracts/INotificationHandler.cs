using SistemaContabil.Core.SharedKernel.Notifications;
using System.Collections.Generic;

namespace SistemaContabil.Core.SharedKernel.Contracts
{
    public interface INotificationHandler
    {
        List<Notification> GetNotifications();
        void Handle(Notification message);
        bool HasNotifications();
    }
}
