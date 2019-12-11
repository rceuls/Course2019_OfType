using Microsoft.EntityFrameworkCore;

namespace TestMvcOfType
{
  public class SchoolContext : DbContext
  {
    public SchoolContext(DbContextOptions<SchoolContext> contextOptions) : base(contextOptions)
    {
    }

    public DbSet<SchoolClass> SchoolClasses { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Teacher> Teachers { get; set; }

  }

  public class DataInitializer
  {
    private SchoolContext _context;

    public DataInitializer(SchoolContext context)
    {
      _context = context;
    }

    public void Initialize()
    {

      if (_context.Database.EnsureCreated())
      {
        _context.SchoolClasses.Add(new SchoolClass
        {
          Persons = new System.Collections.Generic.List<Person>
        {
          new Student { Name = "Student 1", Fired = true},
          new Student { Name = "Student 2", Fired = true},
          new Teacher { Name = "Teacher 1", Hired = true},

        }
        });
        _context.SaveChanges();
      }
    }
  }
}