using AutoMapper;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Mappings
{
   public class DtoMapper:Profile
    {
        public DtoMapper()
        {
            CreateMap<ProductAddDto, Product>().ReverseMap();
        }
        
    }
}
