using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TravelRating.Models
{
  public class Location
  {
    public Location()
    {
      this.Experiences = new HashSet<Experience>();
    }

    public int LocationId { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string City { get; set; }
    [Required]
    public string Country { get; set; }
    
    public virtual ICollection<Experience> Experiences { get; set; }
  }
}