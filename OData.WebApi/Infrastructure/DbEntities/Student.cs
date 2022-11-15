namespace OData.WebApi.Infrastructure.DbEntities;

public class Student
{
    public int Id { get; set; }

    public DateTime CreateDate { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public string EmailAddress { get; set; }

    public int CurrentGradeId { get; set; }

    public virtual Grade Grade { get; set; }
}
