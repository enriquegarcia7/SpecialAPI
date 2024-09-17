using System;
using Microsoft.AspNetCore.Mvc;
using SpeacialAPI.Models;
using SpeacialAPI.Services;


namespace SpeacialAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class MandrilController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Mandril>> GetMandriles()
    {
        return Ok(MandrilDataStore.Current.Mandriles);
    }

    [HttpGet("{MandrilId}")]
    public ActionResult<Mandril> GetMandril(int MandrilId)
    {
        var mandril = MandrilDataStore.Current.Mandriles.FirstOrDefault(c => c.Id == MandrilId);
        if (mandril == null)
        {
            return NotFound("Mandril no encontrado");
        }
        return Ok(mandril);
    }
    [HttpPost]
    public ActionResult<Mandril>PostMandril(MandrilInsert mandrilInsert)
    {
        var lastMandril = MandrilDataStore.Current.Mandriles.Last();
        var newMandril = new Mandril()
        {
            Id = lastMandril.Id + 1,
            Nombre = mandrilInsert.Nombre,
            Apellido = mandrilInsert.Apellido
        };
        MandrilDataStore.Current.Mandriles.Add(newMandril);
        return CreatedAtAction("GetMandril", new { MandrilId = newMandril.Id }, newMandril);
    }
    [HttpPut("{MandrilId}")]
    public ActionResult<Mandril> PutMandril(int MandrilId, MandrilInsert mandrilInsert)
    {
        var mandril = MandrilDataStore.Current.Mandriles.FirstOrDefault(c => c.Id == MandrilId);
        if (mandril == null)
        {
            return NotFound("Mandril no encontrado");
        }
        mandril.Nombre = mandrilInsert.Nombre;
        mandril.Apellido = mandrilInsert.Apellido;
        return Ok(mandril);
    }
    [HttpDelete("{MandrilId}")]
    public ActionResult DeleteMandril(int MandrilId)
    {
        var mandril = MandrilDataStore.Current.Mandriles.FirstOrDefault(c => c.Id == MandrilId);
        if (mandril == null)
        {
            return NotFound("Mandril no encontrado");
        }
        MandrilDataStore.Current.Mandriles.Remove(mandril);
        return NoContent();
    }
}
