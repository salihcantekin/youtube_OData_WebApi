using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OData.WebApi.Infrastructure.DbEntities;

namespace OData.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
public class TestController : ControllerBase
{
    [HttpGet]
    public IEnumerable<Student> GetStudents()
    {
        return new[] 
        {
            new Student()
            { 
                Id = 1,
                FirstName = "Salih",
                LastName = "Cantekin",
                CurrentGradeId = 1,
                EmailAddress = "salihcantekin@gmail.com"
            },
            new Student()
            {
                Id = 2,
                FirstName = "Salih1",
                LastName = "Cantekin",
                CurrentGradeId = 1,
                EmailAddress = "salih1cantekin@gmail.com"
            },
            new Student()
            {
                Id = 3,
                FirstName = "Salih3",
                LastName = "Cantekin",
                CurrentGradeId = 1,
                EmailAddress = "salih1cantekin@gmail.com"
            },
            new Student()
            {
                Id = 4,
                FirstName = "Salih4",
                LastName = "Cantekin",
                CurrentGradeId = 1,
                EmailAddress = "salih1cantekin@gmail.com"
            },
        };
    }
}
