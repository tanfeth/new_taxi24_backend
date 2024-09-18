using AutoMapper;
using System.Collections.Generic;
using Taxi24.Core.Common.Enum;
using Taxi24.Core.Common.Utlities;
using Taxi24.Core.Dto;
using Taxi24.Core.Dto.Admin;
using Taxi24.Core.Entity;
using Taxi24.Core.Response;

namespace Taxi24.Api.Common.Extensions
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<RegisterDriverDto, User>();
            
            //CreateMap<(LookupValues , string lang), LookupValuesDto>()
            //    .ForMember(dest => dest.Name, src => src.MapFrom(opt => opt.Item2 == "en" ? opt.Item1.NameEn : opt.Item1.NameAr));

            CreateMap<RegisterCarDto, Car>();


        }
    }
}
