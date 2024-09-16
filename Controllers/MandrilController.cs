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
}
