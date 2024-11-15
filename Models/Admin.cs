using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_BernersLee_API.Models;
public class Admin
{
    public required int Id { get; set; }
    public required string Name { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }

    public Admin(){}

    public Admin(int id, string name, string lastname, string email, string password)
    {
        Id = id;
        Name = name.Trim().ToLower();
        LastName = lastname.Trim().ToLower();
        Email = email.Trim().ToLower();
        Password = password.Trim().ToLower();
    }
}
