﻿using AutoMapper;
using BookStore.Core.Application.Contracts;
using BookStore.Core.Domain.Entities;
using System;

namespace BookStore.Core.Application.Features.Authors.Query.GetAuthorById
{
    public class GetAuthorByIdBookDto : IMapFrom<Book>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<GetAuthorByIdBookDto, Book>().ReverseMap();
        }
    }
}
