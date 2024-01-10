using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

using BookStore.Core.Domain.Contracts;
using BookStore.Core.Domain.DTOs.SmsSender;

namespace BookStore.Infrastructure.Communication.Services
{
    public class SmsSender : ISmsSender
    {
        private readonly HttpClient httpClient;

        public SmsSender(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task SendSms(SendSmsRequest model)
        {
            var jsonModel = JsonSerializer.Serialize(model);

            var content = new StringContent(jsonModel, System.Text.Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("blablabla", content);
            response.EnsureSuccessStatusCode();    
        }

    }
}
