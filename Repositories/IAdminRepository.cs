using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;

namespace Assessment_BernersLee_API.Repositories;
public interface IAdminRepository
{
    //Get all admins
    Task<List<Admin>> GetAdminsAsync();
    //Get admin by ID
    Task<Admin> GetAdminByIdAsync(int id);
    //Add admin
    Task AddAdminAsync(Admin admin);
    //Update admin
    Task UpdateAdminAsync(Admin admin);
    //Delete admin
    Task DeleteAdminAsync(int id);
}

