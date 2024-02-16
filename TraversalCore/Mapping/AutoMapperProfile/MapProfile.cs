using AutoMapper;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using EntityLayer.Concrete;

namespace TraversalCore.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>().ReverseMap();
            CreateMap<AnnouncementListDto, Announcement>().ReverseMap();
            CreateMap<AnnouncementUpdateDto, Announcement>().ReverseMap();

            CreateMap<AppUserRegisterDto, AppUser>().ReverseMap();
            CreateMap<AppUserSignInDto, AppUser>().ReverseMap();

        }
    }
}
