

using Api.Dtos;
using API.Controllers;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
    public class TeamController : ApiBaseController
{

    private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;


    public TeamController( IUnitOfWork unitofwork, IMapper mapper)
    {

        this.unitofwork = unitofwork;
        this.mapper = mapper;

        

    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<TeamDto>>> Get()
    {
        var entidad = await unitofwork.Teams.GetAllAsync();
        return mapper.Map<List<TeamDto>>(entidad);
    }


    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TeamDto>> Get(int id)
    {
        var entidad = await unitofwork.Teams.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        return this.mapper.Map<TeamDto>(entidad);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<TeamDto>> Put(int id, [FromBody] TeamDto entidadDto)
    {
        if (entidadDto == null)
        {
            return NotFound();
        }
        var entidad = this.mapper.Map<Team>(entidadDto);
        unitofwork.Teams.Update(entidad);
        await unitofwork.SaveAsync();
        return entidadDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var entidad = await unitofwork.Teams.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        unitofwork.Teams.Remove(entidad);
        await unitofwork.SaveAsync();
        return NoContent();
    }
}