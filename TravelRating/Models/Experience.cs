using System.ComponentModel.DataAnnotations;

namespace TravelRating.Models
{
  public class Experience
  {
    public int ExperienceId { get; set; }
    [Required]
    public string Author { get; set; }
    [Required]
    public string Review { get; set; }
    [Required]
    [Range(1, 5, ErrorMessage = "Rating must be between 1 and 5.")]
    public int Rating { get; set; }
    public int LocationId { get; set; } = 0;

    public virtual User User { get; set; }
  }
}