using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_BernersLee_API.Models;
public class Medic
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string IdentificationNumber { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Password { get; set; }

    public Medic(){}

}
