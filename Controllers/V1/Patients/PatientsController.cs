using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Patients;

[ApiController]
[Route("api/v1/patients")]
public class PatientsController : ControllerBase
{
    protected readonly IPatientRepository _patientRepository;
    
    public PatientsController(IPatientRepository patientRepository)
    {
        _patientRepository = patientRepository;
    }
}
