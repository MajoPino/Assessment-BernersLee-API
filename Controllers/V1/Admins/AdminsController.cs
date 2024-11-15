using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Assessment_BernersLee_API.Controllers.V1.Admins;

[ApiController]
[Route("api/v1/admins")]
public class AdminsController : ControllerBase
{
    protected readonly IAdminRepository _adminRepository;
    
    public AdminsController(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }
}
