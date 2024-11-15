using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Data;
using Assessment_BernersLee_API.Models;
using Assessment_BernersLee_API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_BernersLee_API.Services;
public class PatientServices : IPatientRepository
{
     protected readonly AppDbContext _context;
    public PatientServices(AppDbContext context)
    {
        _context = context;
    }

    public async Task Create(Patient patient)
    {
         if (patient == null)
            {
                throw new ArgumentNullException("The new patient cannot be saved as null");
            }
            try
            {
                await _context.Patients.AddAsync(patient);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Failed to add the new patient into the database", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error adding the patient", ex);
            }
    }

    public async Task Delete(int id)
    {
        var patient = await _context.Patients.FindAsync(id);
            if (patient == null)
            {
                throw new ArgumentNullException(nameof(patient), "patient not found");
            }
            else
            {
                _context.Patients.Remove(patient);
                await _context.SaveChangesAsync();
            }
    }

    public async Task<List<Patient>> GetAll()
    {
       if (!_context.Admins.Any())
            {
                throw new InvalidOperationException("Patients not found in the database.");
            }
            return await _context.Patients.ToListAsync();
    }

    public async Task<Patient> GetById(int id)
    {
        try
            {
                var patient = await _context.Patients.FindAsync(id);
                if (patient == null)
                {
                    throw new ArgumentNullException(nameof(patient), "patient not found");
                }
                return patient;
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error retrieving the patient", ex);
            }
    }

    public async Task Update(Patient patient)
    {
        if (patient == null)
            {
                throw new ArgumentNullException(nameof(patient), "patien cannot be null");
            }
            try
            {
                _context.Entry(patient).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception("Failed to update patien in the database", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error updating the patien", ex);
            }
    }
}
