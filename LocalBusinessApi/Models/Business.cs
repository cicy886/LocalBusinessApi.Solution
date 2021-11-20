using System.ComponentModel.DataAnnotations;

namespace LocalBusinessApi.Models
{
  public class Business
  {
    public int BusinessId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; }
    [Required]
    [StringLength(20)]
    public string Category { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    [Range(1, 5, ErrorMessage = "Rate must be between 1 and 5.")]
    public int Rate { get; set; }
    [Required]
    public string Review { get; set; }
  }
}