using WebApplicationCoreAngularLogin.Dtos;
using WebApplicationCoreAngularLogin.Models;
using AutoMapper;
using System.Text;

namespace WebApplicationCoreAngularLogin.Helpers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Book, BookListDto>();
            CreateMap<LoginDto, User>().ReverseMap();
            CreateMap<RegisterDto, User>()
                .ForMember(dist => dist.Password, 
                           opt => opt.MapFrom(src => Encoding.ASCII.GetBytes(src.Password) ) )
                .ReverseMap();
        }
    }
}
