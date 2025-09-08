using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BethanysPieShopHRM.Shared.Domain;

public class Employee
{
    public int EmployeeId { get; set; }

    [Required]
    [StringLength(20, ErrorMessage = "First name cannot be longer than 20 characters.")]
    public string FirstName { get; set; } = string.Empty;

    [Required]
    [StringLength(20, ErrorMessage = "Last name cannot be longer than 20 characters.")]
    public string LastName { get; set; } = string.Empty;

    public DateTime? BirthDate { get; set; }

    [Required]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;

    public string? Street { get; set; }

    public string? Zip { get; set; }

    public string? City { get; set; }

    public int? CountryId { get; set; }

    public Country? Country { get; set; }

    public string? PhoneNumber { get; set; }

    public bool Smoker { get; set; } = false;

    public MaritalStatus? MaritalStatus { get; set; }

    public Gender? Gender { get; set; }

    public bool IsOnHoliday { get; set; } = false;

    [StringLength(500, ErrorMessage = "Address cannot be longer than 500 characters.")]
    public string Comment { get; set; } = string.Empty;

    public DateTime? JoinedDate { get; set; }

    public DateTime? ExitDate { get; set; }

    public int? JobCategoryId { get; set; }

    public JobCategory? JobCategory { get; set; }

    public double? Latitude { get; set; }

    public double? Longitude { get; set; }
    
    [NotMapped]
    public byte[]? ImageContent { get; set; }

    public string? ImageName { get; set; }
}