using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelRating.Models;


namespace TravelRating.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ExperiencesController : ControllerBase
  {
    private TravelRatingContext _db;

    public ExperiencesController(TravelRatingContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Experience>> Get(string author, string review, int rating)
    {
      var query = _db.Experiences.AsQueryable();
      if (author != null)
      {
        query = query.Where(entry => entry.Author == author);
      }
      if (review != null)
      {
        query = query.Where(entry => entry.Review == review);
      }
      if (rating > 0)
      {
        query = query.Where(entry => entry.Rating == rating);
      }
      return query.ToList();
    }

     [HttpPost]
     public void Post([FromBody] Experience experience)
     {
       _db.Experiences.Add(experience);
       _db.SaveChanges();
     }

     [HttpGet("{id}")]
     public ActionResult<Experience> GetAction(int id)
     {
       return _db.Experiences.FirstOrDefault(entry => entry.ExperienceId == id);
     }

     [HttpPut("{id}")]
     public void Put(int id, [FromBody] Experience experience)
     {
       experience.ExperienceId = id;
       _db.Entry(experience).State = EntityState.Modified;
       _db.SaveChanges();
     }

     [HttpDelete("{id}")]
     public void Delete(int id)
     {
       var experienceToDelete = _db.Experiences.FirstOrDefault(entry => entry.ExperienceId == id);
       _db.Experiences.Remove(experienceToDelete);
       _db.SaveChanges();
     }
  }
}