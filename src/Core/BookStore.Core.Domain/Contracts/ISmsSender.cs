using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using BookStore.Core.Domain.DTOs.SmsSender;

namespace BookStore.Core.Domain.Contracts
{
    public interface ISmsSender
    {
        Task SendSms(SendSmsRequest model);
    }
}
