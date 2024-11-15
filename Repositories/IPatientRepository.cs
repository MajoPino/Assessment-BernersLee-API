using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Models;

namespace Assessment_BernersLee_API.Repositories;
public interface IPatientRepository
{
     //Get all patients
    Task<List<Patient>> GetAll();
    //Get patient by ID
    Task<Patient> GetById(int id);
    //Add patient
    Task Create(Patient patient);
    //Update patient
    Task Update(Patient patient);
    //Delete patient
    Task Delete(int id);
}
