using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.DTOs;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Medics;

[ApiController]
[Route("api/v1/medics")]
public class MedicsUpdateController : MedicsController
{
    public MedicsUpdateController(IMedicRepository medicRepository) : base(medicRepository){}

    //PUT: /api/v1/medics/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] MedicDTO medicDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var existingCategory = await _medicRepository.GetById(id);
        if (existingCategory == null)
        {
            return NotFound($"Medic with id {id} not found.");
        }
        
            existingCategory.Id = medicDTO.Id;
            existingCategory.Name = medicDTO.Name;
            existingCategory.LastName = medicDTO.LastName;
            existingCategory.IdentificationNumber = medicDTO.IdentificationNumber;
            existingCategory.Email = medicDTO.Email;
            existingCategory.PhoneNumber = medicDTO.PhoneNumber;
            existingCategory.Password = medicDTO.Password;
        try
        {
            await _medicRepository.Update(existingCategory);
            return Ok(existingCategory);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
