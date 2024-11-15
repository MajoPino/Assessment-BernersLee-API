using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_BernersLee_API.DTOs;
public class AdminDTO
{

    [Key]
    public required int Id { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "The name is too long. Please, enter a valid name.")]
    [MinLength(2, ErrorMessage = "The name is too short. Please, enter a valid name.")]
    public required string Name { get; set; }

    [Required]
    [MaxLength(50, ErrorMessage = "The last name is too long. Please, enter a valid last name.")]
    [MinLength(2, ErrorMessage = "The last name is too short. Please, enter a valid last name.")]
    public required string LastName { get; set; }

    [Required]
    [MaxLength(150, ErrorMessage = "The email address is too long. Please, enter a valid email address.")]
    [MinLength(6, ErrorMessage = "The email address is too short. Please, enter a valid email address.")]
    public required string Email { get; set; }

    [Required]
    [MaxLength(100, ErrorMessage = "The password is too long. Please, enter a valid password.")]
    [MinLength(8, ErrorMessage = "The password is too short. Please, enter a valid password.")]
    public required string Password { get; set; }
}
