using AutoMapper;
using WebApplication.Models;
using WebApplication.Models.DTO;
using WebApplication.Models;


namespace WebApplication.Repo
{
    public class MappingProFile : Profile
    {
        public MappingProFile()     
        {
            CreateMap<Product,ProbuctDto>(MemberList.Destination).ReverseMap();
            CreateMap<Group,GroupDto>(MemberList.Destination).ReverseMap();
            CreateMap<Store,StoreDto>(MemberList.Destination).ReverseMap();    
        }
    }
}
