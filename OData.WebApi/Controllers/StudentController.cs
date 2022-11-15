using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.EntityFrameworkCore;
using OData.WebApi.Infrastructure.Context;

namespace OData.WebApi.Controllers;
[Route("api/[controller]")]
[ApiController]
//[EnableQuery]
public class StudentController : ControllerBase
{
    private StudentDbContext dbContext;

    public StudentController(StudentDbContext dbContext)
    {
        this.dbContext = dbContext;

    }

    [HttpGet]
    [EnableQuery]
    public ActionResult GetStudents()
    {
        var result = dbContext.Students.AsQueryable();

        return Ok(result);
    }

    [HttpGet("GetStudentsWithGrades")]
    [EnableQuery]
    public ActionResult GetStudentsWithGrades()
    {
        var result = dbContext.Students.Include(i => i.Grade).AsQueryable();

        return Ok(result);
    }

    //[HttpGet("Filtered")]
    //public ActionResult GetStudentsFieldsFiltered()
    //{
    //    var result = dbContext.Students.Select(i => new { Id = i.Id, EMailAddress = i.EmailAddress }).ToList();

    //    return Ok(result);
    //}

    //[HttpGet("GetById")]
    //public ActionResult GetById(int id)
    //{
    //    var result = dbContext.Students.Where(i => i.Id == id)
    //        .Select(i => new { Id = i.Id, EMailAddress = i.EmailAddress }).FirstOrDefault();

    //    return Ok(result);
    //}
}
