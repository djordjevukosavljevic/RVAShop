﻿using AutoMapper;
using RVAProdavnica.Data;
using RVAProdavnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVAProdavnica.Services
{
    public class MapperService : Profile
    {
        public MapperService()
        {   
            CreateMap<Product, ProductModel>().ReverseMap();
            CreateMap<User, UserModel>().ReverseMap();
            //CreateMap<User, UserModel>().ReverseMap();
            //CreateMap<Order, OrdderModel>().ReverseMap();
                
            //CreateMap<ProductModel, Product>();
            //.ForMember(dest => dest.Description, opt => opt.MapFrom(src => src.Description));

        }


    }
}
