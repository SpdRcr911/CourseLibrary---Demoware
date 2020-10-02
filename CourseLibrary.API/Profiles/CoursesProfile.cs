using AutoMapper;
using CourseLibrary.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseLibrary.API.Profiles
{
    public class CoursesProfile : Profile
    {
        public CoursesProfile()
        {
            CreateMap<Entities.Course, CourseDto>();
            CreateMap<CourseForCreationDto, Entities.Course>();
            CreateMap<CourseForUpdateDto, Entities.Course>();
            CreateMap<Entities.Course, CourseForUpdateDto > ();
        }
    }
}
