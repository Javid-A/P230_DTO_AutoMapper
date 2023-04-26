using AutoMapper;
using P230DTO.DTOs;
using P230DTO.Entities;

namespace P230DTO.Profiles
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Book, BookGetDTO>();   
            CreateMap<Book, BookPostDTO>().ReverseMap();
            CreateMap<Book, BookPutDTO>().ReverseMap();
            //CreateMap<BookPostDTO, Book>();
        }
    }
}
