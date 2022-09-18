using AutoMapper;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Dtos;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Rules;
using Kodlama.io.Devs.Application.Services.Repositories;
using Kodlama.io.Devs.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Commands.UpdateProgrammingLanguage
{
    public class UpdateProgrammingLanguageCommend:IRequest<UpdateProgrammingLanguageDto>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public class UpdateProgrammingLanguageCommendHandler : IRequestHandler<UpdateProgrammingLanguageCommend, UpdateProgrammingLanguageDto>
        {
            private readonly IProgrammingLanguageRepository _programmingLanguageRepository;
            private readonly IMapper _mapper;
            private readonly ProgrammingLanguageBusinessRules _programmingLanguageBusinessRules;

            public UpdateProgrammingLanguageCommendHandler(IProgrammingLanguageRepository programmingLanguageRepository, IMapper mapper, ProgrammingLanguageBusinessRules programmingLanguageBusinessRules)
            {
                _programmingLanguageRepository = programmingLanguageRepository;
                _mapper = mapper;
                _programmingLanguageBusinessRules = programmingLanguageBusinessRules;
            }

            public async Task<UpdateProgrammingLanguageDto> Handle(UpdateProgrammingLanguageCommend request, CancellationToken cancellationToken)
            {

                
                await _programmingLanguageBusinessRules.ProgrammingLanguageShouldExistWhenRequested(request.Id);
                
                ProgrammingLanguage programmingLanguage = await _programmingLanguageRepository.GetAsync(x => x.Id == request.Id);
                var mapresult = _mapper.Map(request, programmingLanguage);
                var result =await _programmingLanguageRepository.UpdateAsync(mapresult);
                UpdateProgrammingLanguageDto response = _mapper.Map<UpdateProgrammingLanguageDto>(result);
                return response;

            }
        }
    }
}
