using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Data;
using Assessment_BernersLee_API.Models;
using Assessment_BernersLee_API.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Assessment_BernersLee_API.Services;
public class MedicServices : IMedicRepository
{
    protected readonly AppDbContext _context;
        public MedicServices(AppDbContext context)
        {
            _context = context;
        }

    public async Task Create(Medic medic)
    {
        if (medic == null)
            {
                throw new ArgumentNullException("The new medic cannot be saved as null");
            }
            try
            {
                await _context.Medics.AddAsync(medic);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Failed to add the new medic into the database", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error adding the medic", ex);
            }
    }

    public async Task Delete(int id)
    {
        var medic = await _context.Medics.FindAsync(id);
            if (medic == null)
            {
                throw new ArgumentNullException(nameof(medic), "Medic not found");
            }
            else
            {
                _context.Medics.Remove(medic);
                await _context.SaveChangesAsync();
            }
    }

    public async Task<List<Medic>> GetAll()
    {
        if (!_context.Admins.Any())
            {
                throw new InvalidOperationException("Medics not found in the database.");
            }
            return await _context.Medics.ToListAsync();
    }

    public async Task<Medic> GetById(int id)
    {
        try
            {
                var medic = await _context.Medics.FindAsync(id);
                if (medic == null)
                {
                    throw new ArgumentNullException(nameof(medic), "Medic not found");
                }
                return medic;
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error retrieving the medic", ex);
            }
    }

    public async Task Update(Medic medic)
    {
        if (medic == null)
            {
                throw new ArgumentNullException(nameof(medic), "medic cannot be null");
            }
            try
            {
                _context.Entry(medic).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception("Failed to update medic in the database", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error updating the medic", ex);
            }
    }
}
