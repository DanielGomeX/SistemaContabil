using Microsoft.AspNetCore.Mvc;
using SistemaContabil.Core.SharedKernel.Contracts;
using SistemaContabil.Core.SharedKernel.Notifications;
using System.Linq;

namespace SistemaContabil.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SistemaContabilController : ControllerBase
    {
        private readonly INotificationHandler _notifications;

        protected SistemaContabilController(INotificationHandler notifications)
        {
            _notifications = (NotificationHandler)notifications;
        }

        protected virtual IActionResult Response(object result)
        {
            if (OperacaoValida())
            {
                return Ok(new
                {
                    success = true,
                    data = result
                });
            }

            return BadRequest(new
            {
                success = false,
                errors = _notifications.GetNotifications().Select(n => n.Value)
            });
        }

        protected bool OperacaoValida()
        {
            return (!_notifications.HasNotifications());
        }
    }
}