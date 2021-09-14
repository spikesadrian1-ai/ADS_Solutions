using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    //[ApiController]
    //[Route("[controller]")]
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerAddressesMainController : ControllerBase
    {
        private readonly OGDatabaseSchemaV2Context _context;

        public OwnerAddressesMainController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL OWNERS
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<OwnerDetailsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OwnerAddressesMain>>> GetOwnerAddressesMain()
        {
            return await _context.OwnerAddressesMain.ToListAsync();

        }

        /// <summary>
        /// BY OWNER TABLE ID
        /// </summary>
        // GET api/<OwnerDetailsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<OwnerAddressesMain>> GetOwnerAddressesMainDetails(int id)
        {
            var ownerAddressesMain = await _context.OwnerAddressesMain.FindAsync(id);

            if (ownerAddressesMain == null)
            {
                return NotFound();
            }

            return ownerAddressesMain;
        }
    }
}
