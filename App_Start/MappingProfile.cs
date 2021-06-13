using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using computer_store_MVC.Models;
using computer_store_MVC.Dtos;

namespace computer_store_MVC.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            Mapper.CreateMap<Computer, ComputerDto>();
            Mapper.CreateMap<ComputerDto, Computer>();
        }
    }
}