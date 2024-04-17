﻿using AutoMapper;
using DS.Services.ProductAPI.Models;
using DS.Services.ProductAPI.Models.Dto;

namespace DS.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration   RegisterMaps()
        {
            var mappingConfig=new MapperConfiguration(config=>
            {
                config.CreateMap<ProductDto, Product>();
                config.CreateMap<Product, ProductDto>();
            });
            return mappingConfig;
        }
    }
}
