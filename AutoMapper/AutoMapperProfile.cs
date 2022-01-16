using AutoMapper;
using FrediTask.DTO;
using FrediTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FrediTask.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Category, CategoryGetDTO>().ReverseMap();
            CreateMap<CategoryCreateDTO, Category>().ReverseMap();
            CreateMap<CategoryUpdateDTO, Category>().ReverseMap();

            CreateMap<Product, ProductGetDTO>().ReverseMap();
            CreateMap<ProductCreateDTO, Product>().ReverseMap();
            CreateMap<ProductUpdateDTO, Product>().ReverseMap();
        }
    }
}
