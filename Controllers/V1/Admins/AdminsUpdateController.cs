using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.DTOs;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Admins;
public class AdminsUpdateController : AdminsController
{
    public AdminsUpdateController(IAdminRepository adminRepository) : base(adminRepository){}

    //PUT: /api/v1/categories/{id}
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] AdminDTO adminDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var existingCategory = await _adminRepository.GetById(id);
        if (existingCategory == null)
        {
            return NotFound($"Admin with id {id} not found.");
        }
        
            existingCategory.Id = adminDTO.Id;
            existingCategory.Name = adminDTO.Name;
            existingCategory.LastName = adminDTO.LastName;
            existingCategory.Email = adminDTO.Email;
            existingCategory.Password = adminDTO.Password;
        try
        {
            await _adminRepository.Update(existingCategory);
            return Ok(existingCategory);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }

}
