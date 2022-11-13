using AutoMapper;
using PersonAPI.Data;

namespace PersonAPI.Models 
{
    public class PersonViewModel: PersonBase
    {
        public string Gender { get; set; } = "Female";
    }

    public class NameProfile: Profile {
        public NameProfile()
        {            
            CreateMap<Person, PersonViewModel>()
                .ForMember(dest => dest.Gender, opts => opts.MapFrom(src => src.Gender ? "Female" : "Male"));
             
            CreateMap<PersonViewModel, Person>()
                .ForMember(dest => dest.Gender, opts => opts.MapFrom(src => src.Gender == "Male"));
        }
    }  
}
