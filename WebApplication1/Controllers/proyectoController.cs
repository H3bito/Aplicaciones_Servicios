using entrega1.shared.entitys;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.data;

namespace WebApplication1.Controllers
{
    public class proyectoController
    {
        [ApiController]
        [Route("api/proyectos")]
        public class proyectosController : ControllerBase
        {
            private readonly DataContext _context;
            public proyectosController(DataContext context) { _context = context; }
            [HttpGet]
            public async Task<ActionResult> get() { return Ok(await _context.proyectos.ToListAsync()); }


            [HttpGet("{id:int}")]
            public async Task<ActionResult> get(int id)
            {
                //200 ok

                await _context.proyectos.FirstOrDefaultAsync(x => x.id == id);


                return Ok();

            }
            [HttpPost]
            public async Task<ActionResult> Post(proyecto proyecto)
            {

                _context.Add(proyecto);
                await _context.SaveChangesAsync();
                return Ok(proyecto);


            }



        }


    }
}
