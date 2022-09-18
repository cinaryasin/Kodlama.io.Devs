using AutoMapper;
using Core.Persistence.Paging;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Commands.CreateProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Commands.UpdateProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Dtos;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Models;
using Kodlama.io.Devs.Domain.Entities;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Profiles
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            //Create
            CreateMap<ProgrammingLanguage, CreatedProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, CreateProgrammingLanguageCommand>().ReverseMap();
            //List
            CreateMap<IPaginate<ProgrammingLanguage>, ProgrammingLanguageListModel>().ReverseMap();
            CreateMap<ProgrammingLanguage, ListProgrammingLanguageDto>().ReverseMap();
            //GetById
            CreateMap<ProgrammingLanguage, GetByIdProgrammingLanguageDto>().ReverseMap();
            //Update
            CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageDto>().ReverseMap();
            CreateMap<ProgrammingLanguage, UpdateProgrammingLanguageCommend>().ReverseMap();
            //Delete
            CreateMap<ProgrammingLanguage, DeleteProgrammingLanguageDto>().ReverseMap();
        }
    }
}
