using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Medics;
public class MedicsDeleteController : MedicsController
{
    public MedicsDeleteController(IMedicRepository medicRepository) : base(medicRepository){}

    //DELETE: /api/v1/medics/{id}
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        try
        {
            await _medicRepository.Delete(id);
            return Ok("Medic deleted successfully!");
        }
        catch (ArgumentNullException)
        {
            return NotFound($"Medic with id {id} not found.");
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
