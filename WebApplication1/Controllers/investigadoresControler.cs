using entrega1.shared.entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Metrics;
using WebApplication1.data;


namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/investigadores")]
    public class investigadoresControler : ControllerBase
    {
        private readonly DataContext _context;
        public investigadoresControler(DataContext context) { _context = context; }
        [HttpGet]
        public async Task<ActionResult> get() { return Ok(await _context.proyectos.ToListAsync());}


        [HttpGet("{id:int}")]
        public async Task<ActionResult> get(int id) { 
         //200 ok

            await _context.proyectos.FirstOrDefaultAsync(x => x.id == id);


            return Ok();
        
        }
        [HttpPost]
        public async Task<ActionResult> Post(investigador investigador)
        {

            _context.Add(investigador);
            await _context.SaveChangesAsync();
            return Ok(investigador);


        }



    }
}
