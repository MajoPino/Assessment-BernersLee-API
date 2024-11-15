using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment_BernersLee_API.Models;

[Table("patients")]
public class Patient
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("id")]
    public int Id { get; set; }
    
    [Required]
    [Column("name")]
    [MaxLength(50)]
    [MinLength(2)]
    public required string Name { get; set; }

    [Required]
    [Column("last_name")]
    [MaxLength(50)]
    [MinLength(2)]
    public required string LastName { get; set; }

    [Required]
    [Column("identification_number")]
    [MaxLength(50)]
    [MinLength(4)]
    public required string IdentificationNumber { get; set; }

    [Required]
    [Column("email")]
    [MaxLength(150)]
    [MinLength(6)]
    public required string Email { get; set; }

    [Required]
    [Column("phone_number")]
    [MaxLength(20)]
    [MinLength(4)]
    public required string PhoneNumber { get; set; }

    [Required]
    [Column("patient_description")]
    [MaxLength(255)]
    [MinLength(4)]
    public required string PatientDescription { get; set; }

    [Required]
    [Column("password")]
    [MaxLength(100)]
    [MinLength(8)]
    public required string Password { get; set; }

    public Patient(){}
}
