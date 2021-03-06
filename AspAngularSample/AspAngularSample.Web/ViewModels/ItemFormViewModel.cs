﻿namespace AspAngularSample.Web.ViewModels
{
    using AutoMapper;
    using Common.Mapping;
    using Data.Models;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class ItemFormViewModel : IHaveCustomMapping
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public int Quantity { get; set; }

        public void ConfigureMapping(Profile mapper)
        {
            mapper.CreateMap<ItemFormViewModel, Item>()
                 .ForMember(dest => dest.DateOfAdded, opt => opt.MapFrom(val => DateTime.UtcNow))
                 .ReverseMap();
        }
    }
}
