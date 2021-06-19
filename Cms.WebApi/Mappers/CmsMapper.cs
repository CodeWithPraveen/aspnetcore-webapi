using AutoMapper;
using Cms.Data.Repository.Models;
using Cms.WebApi.DTOs;

namespace Cms.WebApi.Mappers
{
    public class CmsMapper: Profile
    {
        public CmsMapper()
        {
            CreateMap<CourseDto, Course>()
                .ReverseMap();

            //CreateMap<Course, CourseDto>();

            CreateMap<StudentDto, Student>()
                .ReverseMap();
        }
    }
}