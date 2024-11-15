using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Assessment_BernersLee_API.Data;
using Assessment_BernersLee_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Assessment_BernersLee_API.Services;
public class AdminServices
{
    protected readonly AppDbContext _context;
        public AdminServices(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(Admin admin)
        {
            if (admin == null)
            {
                throw new ArgumentNullException("The new admin cannot be saved as null");
            }
            try
            {
                await _context.Admins.AddAsync(admin);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException dbEx)
            {
                throw new Exception("Failed to add the new admin into the database", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error adding the admin", ex);
            }
        }
        public async Task Delete(int id)
        {
            var admin = await _context.Admins.FindAsync(id);
            if (admin == null)
            {
                throw new ArgumentNullException(nameof(admin), "Admin not found");
            }
            else
            {
                _context.Admins.Remove(admin);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<IEnumerable<Admin>> Get()
        {
            if (!_context.Admins.Any())
            {
                throw new InvalidOperationException("Admins not found in the database.");
            }
            return await _context.Admins.ToListAsync();
        }
        public async Task<Admin> GetById(int id)
        {
            try
            {
                var admin = await _context.Admins.FindAsync(id);
                if (admin == null)
                {
                    throw new ArgumentNullException(nameof(admin), "Admin not found");
                }
                return admin;
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error retrieving the admin", ex);
            }
        }
        public async Task Update(Admin admin)
        {
            if (admin == null)
            {
                throw new ArgumentNullException(nameof(admin), "admin cannot be null");
            }
            try
            {
                _context.Entry(admin).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException dbEx)
            {
                throw new Exception("Failed to update admin in the database", dbEx);
            }
            catch (Exception ex)
            {
                throw new Exception("Unexpected error updating the admin", ex);
            }
        }
}
