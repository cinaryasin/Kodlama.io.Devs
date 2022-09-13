using Core.Persistence.Repositories;
using Kodlama.io.Devs.Application.Services.Repositories;
using Kodlama.io.Devs.Domain.Entities;
using Kodlama.io.Devs.Persistance.Contexts.MssqlContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Kodlama.io.Devs.Persistance.Repositories.ProgrammingLaguageRepository.ProgrammingLanguageRepository;

namespace Kodlama.io.Devs.Persistance.Repositories.ProgrammingLaguageRepository
{
 
        public class ProgrammingLanguageRepository : EfRepositoryBase<ProgrammingLanguage, MssqlDbContext>, IProgrammingLanguageRepository
    {
            public ProgrammingLanguageRepository(MssqlDbContext context) : base(context)
            {

            }

        }
    }

