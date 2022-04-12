using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TractMainFormsController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public TractMainFormsController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }


        /// <summary>
        /// ALL OWNERS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<TractMainFormsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TractMainForm>>> GetTractMainForm()
        {
            return await _context.TractMainForm.ToListAsync();
        }
  

        /// <summary>
        /// BY TRACT TABLE ID
        /// </summary>
        // GET api/<TractMainFormsController>/5
        [HttpGet("GetTractMainFormDetails/{id}")]
        public async Task<ActionResult<TractMainForm>> GetTractMainFormDetails(int id)
        {
            var tractMainForm = await _context.TractMainForm.FindAsync(id);

            if (tractMainForm == null)
            {
                return NotFound();
            }

            return tractMainForm;
        }



    }
}
