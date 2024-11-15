using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.DTOs;
using Assessment_BernersLee_API.Models;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Patients;
[ApiController]
[Route("api/v1/patients")]
public class PatientsCreateController : PatientsController
{
    public PatientsCreateController(IPatientRepository patientRepository) : base(patientRepository){}

    //POST: /api/v1/patients
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] PatientDTO patientDTO)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        var patient = new Patient
        {
            Id = patientDTO.Id,
            Name = patientDTO.Name,
            LastName = patientDTO.LastName,
            IdentificationNumber = patientDTO.IdentificationNumber,
            Email = patientDTO.Email,
            PhoneNumber = patientDTO.PhoneNumber,
            PatientDescription = patientDTO.PatientDescription,
            Password = patientDTO.Password
            
        };
        try
        {
            await _patientRepository.Create(patient);
            return Ok(patient);
        }
        catch (Exception ex)
        {
            return StatusCode(500, ex.Message);
        }
    }
}
