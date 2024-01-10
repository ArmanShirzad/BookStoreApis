using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Domain.DTOs.SmsSender
{
    public class SendSmsRequest
    {
        public string PhoneNumber { get; set; }
        public string Message { get; set; }
    }
}
