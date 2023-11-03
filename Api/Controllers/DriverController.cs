
using Api.Dtos;
using API.Controllers;
using AutoMapper;
using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;
    public class DriverController: ApiBaseController
{

    private readonly IUnitOfWork unitofwork;
    private readonly IMapper mapper;


    public DriverController( IUnitOfWork unitofwork, IMapper mapper)
    {

        this.unitofwork = unitofwork;
        this.mapper = mapper;

        

    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<DriverDto>>> Get()
    {
        var entidad = await unitofwork.Drivers.GetAllAsync();
        return mapper.Map<List<DriverDto>>(entidad);
    }


    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<DriverDto>> Get(int id)
    {
        var entidad = await unitofwork.Drivers.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        return this.mapper.Map<DriverDto>(entidad);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<DriverDto>> Put(int id, [FromBody] DriverDto entidadDto)
    {
        if (entidadDto == null)
        {
            return NotFound();
        }
        var entidad = this.mapper.Map<Driver>(entidadDto);
        unitofwork.Drivers.Update(entidad);
        await unitofwork.SaveAsync();
        return entidadDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var entidad = await unitofwork.Drivers.GetByIdAsync(id);
        if (entidad == null)
        {
            return NotFound();
        }
        unitofwork.Drivers.Remove(entidad);
        await unitofwork.SaveAsync();
        return NoContent();
    }
}