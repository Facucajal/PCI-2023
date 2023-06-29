﻿using BETARJETA_2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BETARJETA_2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetaController : ControllerBase
    { 
        private readonly AplicationDbContext _context;
        public TarjetaController(AplicationDbContext context) 
        {
            _context = context;
        }

        // GET: api/<ValuesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var listTarjetas = await _context.TarjetaCredito.ToListAsync();
                return Ok(listTarjetas);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ValuesController>
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] TarjetaCredito tarjeta)
        {
            try 
            {
                _context.Add(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(tarjeta);
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, [FromBody] TarjetaCredito tarjeta)
        {
            try
            {
                if(id != tarjeta.id)
                {
                    return NotFound();
                }
                _context.Update(tarjeta);

                await _context.SaveChangesAsync();
                return Ok(new { message = "La Tarjeta fue actualizada exitosamente!"});
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var tarjeta = await _context.TarjetaCredito.FindAsync(id);

                if(tarjeta == null)
                {
                    return NotFound();
                }

                _context.TarjetaCredito.Remove(tarjeta);
                await _context.SaveChangesAsync();
                return Ok(new { message = "La Tarjeta fue Eliminada exitosamente!" });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
