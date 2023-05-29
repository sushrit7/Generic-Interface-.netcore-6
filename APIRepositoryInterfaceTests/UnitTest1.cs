using System.Collections.Generic;
using APIRepositoryInterface.Models;
using APIRepositoryInterface.Service;
using Moq;
using Xunit;
using Bogus;

public class EmployeeServiceTests
{
    [Fact]
    public void GetAll_ReturnsAllEmployees()
    {
        // Arrange
        var mockEmployeeService = new Mock<EmployeeService>();

        var employeeFaker = new Faker<Employee>()
            .RuleFor(e => e.id, f => f.Random.Int(1, 100))
            .RuleFor(e => e.Name, f => f.Person.FullName)
            .RuleFor(e => e.ApplyingPosition, f => f.Name.JobTitle());


        var expectedEmployees = employeeFaker.Generate(3);

        mockEmployeeService.Setup(service => service.GetAll()).Returns(expectedEmployees);

        // Act
        var actualEmployees = mockEmployeeService.Object.GetAll();

        // Assert
        Assert.Equal(expectedEmployees, actualEmployees);
    }
}

    