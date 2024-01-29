using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SistemaCodigoProgramacionBack.Models;
using SistemaCodigoProgramacionBack.Utilities;
using System.Collections.Generic;
using SistemaCodigoProgramacionBack.DTOs;
using System.Threading.Tasks;

namespace SistemaCodigoProgramacionBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodigoController : ControllerBase
    {
        /*Creamos la propiedad privada para traer la db*/
        private readonly ApplicationDbContext _context;
        /*Creamos la propiedad privada de mapeo*/
        private readonly IMapper _mapper;

        /*Creacion del constructor*/
        /*Se inyecta la base de datos*/
        /*Se inyecta el servicio de mapeo */
        public CodigoController(ApplicationDbContext dbContext, IMapper mapper)
        {
            /*Se inicializa como un campo*/
            _context = dbContext;
            /*Inicializamos la variable de mapeo*/
            _mapper = mapper;
        }

        /*Listado de todo el codigo*/
        [HttpGet]
        public async Task<ActionResult<List<CodigoDTO>>> GetCodigo()
        {
            var codigo = await _context.codigos.ToListAsync();
            return _mapper.Map<List<CodigoDTO>>(codigo);
        }

        /*Listado de codigo por id*/
        [HttpGet("{id}", Name = "GetCodigo")]
        public async Task<ActionResult<CodigoDTO>> GetById(int id) 
        {
            var codigoById = await _context.codigos.FirstOrDefaultAsync(i => i.id == id);
            
            if (codigoById == null)
            {
                return NotFound();
            }
            return _mapper.Map<CodigoDTO>(codigoById);
        }

        /*Agregar un nuevo codigo*/
        [HttpPost]
        public async Task<ActionResult> PostCodigo(CodigoCreationDTO codigoCreationDTO) 
        {
            var codigo = _mapper.Map<Codigo>(codigoCreationDTO);
            _context.Add(codigo);
            await _context.SaveChangesAsync();
            var codigoDTO = _mapper.Map<CodigoDTO>(codigo);
            return new CreatedAtRouteResult("GetCodigo", new { id = codigo.id}, codigoDTO);
        }
        /*Actualizar un nuevo codigo*/
        [HttpPut("{id}")]
        public async Task<ActionResult> PutCodigo(int id, CodigoCreationDTO codigoCreationDTO) 
        {
            var codigoById = await _context.codigos.FirstOrDefaultAsync(i => i.id == id);
            if (codigoById == null)
            {
                return NotFound();
            }

            _mapper.Map(codigoCreationDTO, codigoById);
            _context.Entry(codigoById).State = EntityState.Modified;

            await _context.SaveChangesAsync();

            return NoContent();
        }
        /*Eliminar codigo*/
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteCodigo(int id) 
        {
            var codigoEliminarId = await _context.codigos.FirstOrDefaultAsync(c => c.id == id);
            if (codigoEliminarId == null)
            {
                return NotFound();
            }

            _context.Entry(codigoEliminarId).State = EntityState.Deleted;
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
