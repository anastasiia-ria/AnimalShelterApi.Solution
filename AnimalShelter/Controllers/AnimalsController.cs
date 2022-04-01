using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using AnimalShelter.Filter;
using AnimalShelter.Helpers;
using AnimalShelter.Models;
using AnimalShelter.Services;
using AnimalShelter.Wrappers;
namespace AnimalShelterControllers

{
  [ApiVersion("1.0")]
  [Route("api/{m:apiVersion}/animals")]
  public class AnimalsV1Controller : ControllerBase
  {
    private readonly AnimalShelterContext db;
    private readonly IUriService uriService;

    public AnimalsV1Controller(AnimalShelterContext db, IUriService uriService)
    {
      this.db = db;
      this.uriService = uriService;

    }

    // GET: api/1.0/Animals
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] PaginationFilter filter, string species, string sex, string color, string breed)
    {
      var route = Request.Path.Value;
      var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);

      var query = db.Animals.AsQueryable();
      if (sex != null)
      {
        query = query.Where(entry => entry.Sex == sex);
      }
      if (color != null)
      {
        query = query.Where(entry => entry.Color == color);
      }
      if (breed != null)
      {
        query = query.Where(entry => entry.Breed == breed);
      }
      if (species != null)
      {
        query = query.Where(entry => entry.Species == species);
      }
      var pagedData = await query
          .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
          .Take(validFilter.PageSize)
          .ToListAsync();
      var totalRecords = await db.Animals.CountAsync();
      var pagedResponse = PaginationHelper.CreatePagedResponse<Animal>(pagedData, validFilter, totalRecords, uriService, route);
      return Ok(pagedResponse);
    }
    // GET: api/1.0/Animals/random
    [HttpGet("random")]
    public async Task<IActionResult> GetRandom()
    {
      Random rnd = new Random();

      int id = rnd.Next(db.Animals.Count()) + 1;
      var animal = await db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      return Ok(animal);
    }
    // GET: api/1.0/Animals/5
    [HttpGet("{id}")]
    public async Task<IActionResult> GetAnimal(int id)
    {
      var animal = await db.Animals.FindAsync(id);

      if (animal == null)
      {
        return NotFound();
      }

      return Ok(animal);
    }

    // PUT: api/1.0/Animals/5
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAnimal(int id, Animal animal)
    {
      if (id != animal.AnimalId)
      {
        return BadRequest();
      }

      db.Entry(animal).State = EntityState.Modified;

      try
      {
        await db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!AnimalExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }

      return NoContent();
    }

    // POST: api/1.0/Animals
    // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    [HttpPost]
    public async Task<ActionResult<Animal>> PostAnimal(Animal animal)
    {
      db.Animals.Add(animal);
      await db.SaveChangesAsync();

      return CreatedAtAction("GeAll", new { id = animal.AnimalId }, animal);
    }

    // DELETE: api/1.0/Animals/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAnimal(int id)
    {
      var animal = await db.Animals.FindAsync(id);
      if (animal == null)
      {
        return NotFound();
      }

      db.Animals.Remove(animal);
      await db.SaveChangesAsync();

      return NoContent();
    }

    private bool AnimalExists(int id)
    {
      return db.Animals.Any(e => e.AnimalId == id);
    }
  }
}
