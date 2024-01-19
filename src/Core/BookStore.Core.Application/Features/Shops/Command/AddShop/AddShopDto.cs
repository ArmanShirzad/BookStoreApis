using AutoMapper;

using BookStore.Core.Application.Contracts;
using BookStore.Core.Domain.Entities;

using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Core.Application.Features.Shops.Command.AddShop
{
    public class AddShopDto : IMapFrom<Shop>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddShopDto, Author>()
                .ReverseMap();
        }
    }
}
