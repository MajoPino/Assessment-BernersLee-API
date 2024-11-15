using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Admins;

[ApiController]
[Route("api/v1/admins")]
public class AdminsDeleteController : AdminsController
{
    public AdminsDeleteController(IAdminRepository adminRepository) : base(adminRepository){}

    //DELETE: /api/v1/categories/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _adminRepository.Delete(id);
            return Ok("Admin deleted successfully!");
        }
        catch (ArgumentNullException)
        {
            return NotFound($"Admin with id {id} not found.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
