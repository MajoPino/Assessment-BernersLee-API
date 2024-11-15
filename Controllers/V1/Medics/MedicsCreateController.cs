using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.DTOs;
using Assessment_BernersLee_API.Models;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Medics;

[ApiController]
[Route("api/v1/medics")]
public class MedicsCreateController : MedicsController
{
    public MedicsCreateController(IMedicRepository medicRepository) : base(medicRepository){}

    //POST: /api/v1/medics
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] MedicDTO medicDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var medic = new Medic
        {
            Id = medicDTO.Id,
            Name = medicDTO.Name,
            LastName = medicDTO.LastName,
            IdentificationNumber = medicDTO.IdentificationNumber,
            Email = medicDTO.Email,
            PhoneNumber = medicDTO.PhoneNumber,
            Password = medicDTO.Password
            
        };
        try
        {
            await _medicRepository.Create(medic);
            return Ok(medic);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
