using FluentValidation.Results;
using SistemaContabil.Core.Contracts;
using SistemaContabil.Core.SharedKernel.Contracts;
using SistemaContabil.Core.SharedKernel.Notifications;
using System;

namespace SistemaContabil.Core.SharedKernel.Services
{
    public class BaseService
    {
        protected readonly INotificationHandler _notificationHandler;
        protected readonly IUnitOfWork _unitOfWork;

        public BaseService(INotificationHandler notificationHandler, IUnitOfWork unitOfWork)
        {
            _notificationHandler = notificationHandler;
            _unitOfWork = unitOfWork;
        }

        protected void NotificarValidacoesErro(ValidationResult validationResult)
        {
            foreach (var error in validationResult.Errors)
                _notificationHandler.Handle(new Notification(error.PropertyName, error.ErrorMessage, error.ErrorCode));
        }

        public bool HasNotification()
        {
            return _notificationHandler.HasNotifications();
        }

        protected bool Commit()
        {
            if (_notificationHandler.HasNotifications()) return false;
            try
            {
                if (_unitOfWork.Commit()) return true;
            }
            catch (Exception e)
            {
                throw;
            }

            _notificationHandler.Handle(new Notification("Commit", "Ocorreu um erro ao salvar os dados no banco"));
            return false;
        }
    }
}
