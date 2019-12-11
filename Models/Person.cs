using System.ComponentModel.DataAnnotations;

namespace TestMvcOfType
{
  public abstract class Person
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public SchoolClass SchoolClass { get; set; }
  }
}