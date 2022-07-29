using System.ComponentModel;
using System.ComponentModel.DataAnnotations; // [Key] Tells it is a primary key
                                             // [Required] Tells it is required
namespace SimpleWebAPP.Models;
public class Category
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [DisplayName("Display Order")]
    public string DisplayOrder { get; set; }
    // Sets default datetime to current time
    public DateTime CreatedDateTime { get; set; } = DateTime.Now;


}

