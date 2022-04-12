using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Http;
using WebAPI.Repositories;

namespace WebAPI.Controllers
{   
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerAddressesMainController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
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
        [HttpGet("GetOwnerAddressesMainDetails/{id}")]
        public async Task<ActionResult<OwnerAddressesMain>> GetOwnerAddressesMainDetails(int id)
        {
            var ownerAddressesMain = await _context.OwnerAddressesMain.FindAsync(id);

            if (ownerAddressesMain == null)
            {
                return NotFound();
            }

            return ownerAddressesMain;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchOwners}")]
        public async Task<IEnumerable<OwnerAddressesMain>> SearchOwners(string name)
        {
            try
            {
                var result = await SearchOwners(name);

                if (result.Any())
                {
                    return (IEnumerable<OwnerAddressesMain>)Ok(result);
                }

                return (IEnumerable<OwnerAddressesMain>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<OwnerAddressesMain>)StatusCode(StatusCodes.Status500InternalServerError,
                    "Error retrieving data from database");

            }
        }


        //public async Task<OwnerAddressesMain> AddOwner(OwnerAddressesMain ownerAddressesMain)
        //{
        //    var result = await OGDatabaseSchemaV2Context.OwnerAddressesMain.AddAsync(ownerAddressesMain);
        //    await OGDatabaseSchemaV2Context
        //}


        //public async Task<IEnumerable<IOwnerRepository>> SearchOwners(string name, string tractid)
        // {


        // }

        //public async Task<IEnumerable<OwnerAddressesMain>> SearchOwners(string name, string tractid)
        ////async Task<IEnumerable<OwnerAddressesMain>> IOwnerRepository.SearchOwners(string name, string tractid)
        //{
        //    IQueryable<OwnerAddressesMain> query = _context.OwnerAddressesMain;

        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        query = query.Where(e => e.FullName.Contains(name)
        //                         || e.TractId.Contains(tractid));

        //    }
        //    if (tractid != null)
        //    {
        //        query = query.Where(e => e.TractId == tractid);
        //    }

        //    return await query.ToList();
        //}

        //async Task<object> IOwnerRepository.SearchOwners1(string name, string tractid)
        //{
        //    IQueryable<OwnerAddressesMain> query = _context.OwnerAddressesMain;

        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        query = query.Where(e => e.FullName.Contains(name)
        //                         || e.TractId.Contains(tractid));

        //    }
        //    if (tractid != null)
        //    {
        //        query = query.Where(e => e.TractId == tractid);
        //    }

        //    return await query.ToList();
        //}


    }
}
