using System;
using System.Collections.Generic;
using BethanysPieShopHRM.Shared.Domain;

namespace BethanysPieShopFHM.Services;

public class MockDataService
{
    private static List<Employee> _employees = [];
    private static List<JobCategory> _jobCategories = [];
    private static List<Country> _countries = [];

    public static List<Employee> Employees
    {
        get
        {
            _countries = InitializeMockCountries();
            _jobCategories = InitializeMockJobCategories();
            _employees = InitializeMockEmployees();
            
            return _employees;
        }
    }

    private static List<Country> InitializeMockCountries()
    {
        return [];
    }

    private static List<JobCategory> InitializeMockJobCategories()
    {
        return [];
    }

    private static List<Employee> InitializeMockEmployees()
    {
        var e2 = new Employee
        {
            MaritalStatus = MaritalStatus.Married,
            BirthDate = new DateTime(1980, 1, 16),
            City = "Pretoria",
            Email = "mary@bethanyspieshop.com",
            EmployeeId = 2,
            FirstName = "Mary",
            LastName = String.Empty,
            Gender = Gender.Female,
            PhoneNumber = "33999909923",
            Smoker = false,
            Street = "New Street",
            Zip = "2000",
            // JobCategory = _jobCategories[1],
            // JobCategoryId = _jobCategories[1].JobCategoryId,
            Comment = "Lorem Ipsum",
            ExitDate = null,
            JoinedDate = new DateTime(2017, 12, 24),
            // Country = _countries[1],
            // CountryId = _countries[1].CountryId
        };
        
        var e3 = new Employee
        {
            MaritalStatus = MaritalStatus.Married,
            BirthDate = new DateTime(1979, 1, 16),
            City = "Antwerp",
            Email = "gill@bethanyspieshop.com",
            EmployeeId = 3,
            FirstName = "Jane",
            LastName = String.Empty,
            Gender = Gender.Female,
            PhoneNumber = "33999909923",
            Smoker = false,
            Street = "New Street",
            Zip = "2000",
            // JobCategory = _jobCategories[1],
            // JobCategoryId = _jobCategories[1].JobCategoryId,
            Comment = "Lorem Ipsum",
            ExitDate = null,
            JoinedDate = new DateTime(2017, 12, 24),
            // Country = _countries[1],
            // CountryId = _countries[1].CountryId
        };

        return new List<Employee>() { e2, e3 };        
    }
    
    public void GetEmployee()
    {

    }
}