using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Medics;

[ApiController]
[Route("api/v1/medics")]
public class MedicsController : ControllerBase
{
    protected readonly IMedicRepository _medicRepository;
    
    public MedicsController(IMedicRepository medicRepository)
    {
        _medicRepository = medicRepository;
    }
}
