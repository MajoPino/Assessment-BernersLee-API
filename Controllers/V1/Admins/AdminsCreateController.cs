using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.DTOs;
using Assessment_BernersLee_API.Models;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Admins;

[ApiController]
[Route("api/v1/admins")]
public class AdminsCreateController : AdminsController
{
    public AdminsCreateController(IAdminRepository adminRepository) : base(adminRepository){}

    //POST: /api/v1/categories
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] AdminDTO adminDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var admin = new Admin
        {
            Id = adminDTO.Id,
            Name = adminDTO.Name,
            LastName = adminDTO.LastName,
            Email = adminDTO.Email,
            Password = adminDTO.Password
            
        };
        try
        {
            await _adminRepository.Create(admin);
            return Ok(admin);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
