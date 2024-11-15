using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Patients;

[ApiController]
[Route("api/v1/patients")]
public class PatientsGetController : PatientsController
{
    public PatientsGetController(IPatientRepository patientRepository) : base(patientRepository){}

    //GET: /api/v1/patients
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        try
        {
            var patients = await _patientRepository.GetAll();
            return Ok(patients);
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
    //GET: api/v1/patients/{id}
    [HttpGet("{id}")]
    public async Task<IActionResult> GetyById(int id)
    {
        try
        {
            var patient = await _patientRepository.GetById(id);
            if (patient == null)
            {
                return NotFound($"Patient with id {id} not found.");
            }
            return Ok(patient);
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
