
using Core.Application.Requests;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Commands.CreateProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Commands.DeleteProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Commands.UpdateProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Dtos;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Models;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Queries.GetByIdProgrammingLanguage;
using Kodlama.io.Devs.Application.Features.ProgrammingLanguagesFeature.Queries.GetListProgrammingLanguage;
using Microsoft.AspNetCore.Mvc;

namespace Kodlama.io.Devs.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProgrammingLanguagesController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> GetList([FromQuery] PageRequest pageRequest)
        {
            GetListProgrammingLanguageQuery getListProgrammingLanguageQuery = new() { PageRequest = pageRequest };
            ProgrammingLanguageListModel result = await Mediator.Send(getListProgrammingLanguageQuery);
            return Ok(result);
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] GetByIdProgrammingLanguageQuery request)
        {
            GetByIdProgrammingLanguageQuery getByIdProgrammingLanguage = new() { Id = request.Id };
            GetByIdProgrammingLanguageDto result = await Mediator.Send(getByIdProgrammingLanguage);
            return Ok(result);
        }
        [HttpPost("Add")]
        public async Task<IActionResult> Add([FromBody] CreateProgrammingLanguageCommand createProgrammingLanguageCommand)
        {
            CreatedProgrammingLanguageDto result = await Mediator.Send(createProgrammingLanguageCommand);
            return Created("", result);
        }
        [HttpPost("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateProgrammingLanguageCommend updateProgrammingLanguageCommend)
        {
            UpdateProgrammingLanguageDto result = await Mediator.Send(updateProgrammingLanguageCommend);
            return Ok(result);
        }
        [HttpPost("Delete")]
        public async Task<IActionResult> Delete([FromBody] DeleteProgrammingLanguageCommand deleteProgrammingLanguageCommand)
        {
            DeleteProgrammingLanguageDto result = await Mediator.Send(deleteProgrammingLanguageCommand);
            return Ok(result);
        }
    }
}
