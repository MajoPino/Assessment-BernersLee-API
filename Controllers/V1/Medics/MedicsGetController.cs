using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Medics;
public class MedicsGetController : MedicsController
{
    public MedicsGetController(IMedicRepository medicRepository) : base(medicRepository){}

    //GET: /api/v1/medics
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var medics = await _medicRepository.GetAll();
            return Ok(medics);
        }
        catch (InvalidOperationException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An unexpected error occurred.");
        }
    }
    //GET: api/v1/medics/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetyById(int id)
    {
        try
        {
            var medic = await _medicRepository.GetById(id);
            if (medic == null)
            {
                return NotFound($"Medic with id {id} not found.");
            }
            return Ok(medic);
        }
        catch (ArgumentNullException ex)
        {
            return NotFound(ex.Message);
        }
        catch (Exception)
        {
            return StatusCode(500, "An unexpected error occurred.");
        }
    }
}
