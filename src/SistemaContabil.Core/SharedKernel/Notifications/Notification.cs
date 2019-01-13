using System;

namespace SistemaContabil.Core.SharedKernel.Notifications
{
    public class Notification
    {
        public Notification(string key, string value, string statusCode = "400")
        {
            Id = Guid.NewGuid();
            Key = key;
            Value = value;
            ErrorCode = statusCode;
        }

        public Guid Id { get; }
        public string Key { get; }
        public string Value { get; }

        public string ErrorCode { get; set; }
    }
}
