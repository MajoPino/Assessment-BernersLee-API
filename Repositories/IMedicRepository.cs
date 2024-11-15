using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;

namespace Assessment_BernersLee_API.Repositories;
public interface IMedicRepository
{
    //Get all medics
    Task<List<Medic>> GetAll();
    //Get medic by ID
    Task<Medic> GetById(int id);
    //Add medic
    Task Create(Medic medic);
    //Update medic
    Task Update(Medic medic);
    //Delete medic
    Task Delete(int id);

}
