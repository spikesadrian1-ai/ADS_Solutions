using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountyMasterController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public CountyMasterController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL Burdens
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<CountyMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CountyMasterMainForm>>> RetrieveAllCounties()
        {
            return await _context.CountyMasterMainForm.ToListAsync();

        }


        /// <summary>
        /// BY Burdens TABLE ID
        /// </summary>
        [HttpGet("GetAllCounties/{id}")]
        public async Task<ActionResult<CountyMasterMainForm>> GetAllCounties(int id)
        {
            var countyMasterMain = await _context.CountyMasterMainForm.FindAsync(id);

            if (countyMasterMain == null)
            {
                return NotFound();
            }

            return countyMasterMain;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllCounties}")]
        public async Task<IEnumerable<CountyMasterMainForm>> SearchAllCounties(string name)
        {
            try
            {
                var result = await SearchAllCounties(name);

                if (result.Any())
                {
                    return (IEnumerable<CountyMasterMainForm>)Ok(result);
                }

                return (IEnumerable<CountyMasterMainForm>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<CountyMasterMainForm>)StatusCode(StatusCodes.Status500InternalServerError,
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
