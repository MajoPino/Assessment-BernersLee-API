using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;

namespace Assessment_BernersLee_API.Repositories;
public interface IAdminRepository
{
    //Get all admins
    Task<List<Admin>> Get();
    //Get admin by ID
    Task<Admin> GetById(int id);
    //Add admin
    Task Add(Admin admin);
    //Update admin
    Task Update(Admin admin);
    //Delete admin
    Task Delete(int id);
}

