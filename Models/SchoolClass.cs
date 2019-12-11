using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TestMvcOfType
{
  public class SchoolClass
  {
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Person> Persons { get; set; }
  }
}