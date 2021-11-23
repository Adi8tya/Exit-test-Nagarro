using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using WebApplicationAPI.Data.Entitis;
using WebApplicationAPI.Dtos;

namespace WebApplicationAPI.Helpers
{
    public class AutoMapperProfiles:Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Booking,BookingDto>().ReverseMap();
        }
       
    }
}
