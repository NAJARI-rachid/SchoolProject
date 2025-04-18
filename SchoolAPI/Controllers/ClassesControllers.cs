using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;
using DAL.Models;
using DAL;


[ApiController]
[Route("Classe")]
public class ClasseController : ControllerBase
{
    private readonly AppDbContext _db;
    
    public ClasseController(AppDbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<CreatClasseDto>>> GetAll()
    {
        var query = await _db.Classes.ToListAsync();
        return Ok(query);

    }
    [HttpPost]
    public async Task<ActionResult<CreatClasseDto>> Create(CreatClasseDto input)//input c'est ce que j'envoie dans ma route
    {
        Console.WriteLine(input.Name);
        var classe = new Class { Name = input.Name,  Promo = input.Promo };
        _db.Classes.Add(classe);
        await _db.SaveChangesAsync();
        return CreatedAtAction(nameof(GetAll), new { id = classe.Id }, input);
    }



}