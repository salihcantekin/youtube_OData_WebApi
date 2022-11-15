namespace OData.WebApi.Infrastructure.DbEntities;

public class Grade
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<Student> Students { get; set; }
}
