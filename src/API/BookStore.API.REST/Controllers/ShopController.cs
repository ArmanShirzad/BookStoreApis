using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.API.REST.Controllers
{
    public class ShopController : BaseController
    {
        public ShopController(ISender sender) : base(sender)
        {
        }
    }
}
