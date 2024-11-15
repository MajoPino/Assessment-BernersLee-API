using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Admins;

[ApiController]
[Route("api/v1/admins")]
public class AdminGetController : AdminsController
{
    public AdminGetController(IAdminRepository adminRepository) : base(adminRepository){}

    //GET: /api/v1/admins
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var admins = await _adminRepository.GetAll();
            return Ok(admins);
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
    //GET: api/v1/admins/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetyById(int id)
    {
        try
        {
            var admin = await _adminRepository.GetById(id);
            if (admin == null)
            {
                return NotFound($"Admin with id {id} not found.");
            }
            return Ok(admin);
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
