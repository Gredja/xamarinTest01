using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Study02.Domain.Models;
using Dto = Study02.Infrastructure.Dto;

namespace Study02.Domain.Services
{
    public class DomainMappingProfile : Profile
    {
        public DomainMappingProfile()
        {
            CreateMap<Credit, Dto.Credit>();
            CreateMap<Dto.Credit, Credit>();
            CreateMap<Debtor, Dto.Debtor>();
            CreateMap<Dto.Debtor, Debtor>();
            CreateMap<User, Dto.User>();
            CreateMap<Dto.User, User>();
        }
    }
}
