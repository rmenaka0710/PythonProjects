using AutoMapper;
using DIEmployeeExample.DTO;
using DIEmployeeExample.Model;

namespace DIEmployeeExample.Profiles
{
    public class EmpProfile : Profile
    {
        public EmpProfile()
        {
            CreateMap<Emp, EmployeeDTO>().ForMember(dest =>
                                           dest.EmployeeName,
                                           opt => opt.MapFrom(src => src.Name));
            CreateMap<EmployeeDTO, Emp>().ForMember(dest =>
                dest.Name,
                opt => opt.MapFrom(src => src.EmployeeName)); 
        }
    }
}
