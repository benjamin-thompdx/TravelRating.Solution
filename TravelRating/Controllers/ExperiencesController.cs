using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TravelRating.Models;
using Microsoft.AspNetCore.Authorization;
using TravelRating.Services;
using TravelRating.Entities;

namespace TravelRating.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class ExperiencesController : ControllerBase
  {
    private TravelRatingContext _db;
    private IUserService _userService;

    public ExperiencesController(TravelRatingContext db, IUserService userService)
    {
      _db = db;
      _userService = userService;
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

    // Edit Method for Application

    //  [HttpPut("{id}")]
    //  public void Put(int id, [FromBody] Experience experience, string author)
    //  {
    //     experience.ExperienceId = id;
    //     if (experience.Author == author)
    //     {
    //       _db.Entry(experience).State = EntityState.Modified;
    //       _db.SaveChanges();
    //     }
    //  }

    [HttpPut("{id}")]
     public void Put(int id, [FromBody] Experience experience)
    {
      experience.ExperienceId = id;
      _db.Entry(experience).State = EntityState.Modified;
      _db.SaveChanges();
    }

    // Delete Method for Application

    //  [HttpDelete("{id}")]
    //  public void Delete(int id, string author)
    //  {
    //     var experienceToDelete = _db.Experiences.FirstOrDefault(entry => entry.ExperienceId == id);
    //     if (experienceToDelete.Author == author)
    //     {
    //       _db.Experiences.Remove(experienceToDelete);
    //       _db.SaveChanges();
    //     }
    //  }

      [HttpDelete("{id}")]
      public void Delete(int id)
      {
        var experienceToDelete = _db.Experiences.FirstOrDefault(entry => entry.ExperienceId == id);
        _db.Experiences.Remove(experienceToDelete);
        _db.SaveChanges();
      }
  }
}