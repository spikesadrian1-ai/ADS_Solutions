using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsMasterController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public DistrictsMasterController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL Districts
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<DistrictsMasterController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DistrictMasterMain>>> RetrieveAllDistricts()
        {
            return await _context.DistrictMasterMain.ToListAsync();

        }


        /// <summary>
        /// BY Districts TABLE ID
        /// </summary>
        [HttpGet("GetAllDistricts/{id}")]
        public async Task<ActionResult<DistrictMasterMain>> GetAllDistricts(int id)
        {
            var districtMaster = await _context.DistrictMasterMain.FindAsync(id);

            if (districtMaster == null)
            {
                return NotFound();
            }

            return districtMaster;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllDistricts}")]
        public async Task<IEnumerable<DistrictMasterMain>> SearchAllDistricts(string name)
        {
            try
            {
                var result = await SearchAllDistricts(name);

                if (result.Any())
                {
                    return (IEnumerable<DistrictMasterMain>)Ok(result);
                }

                return (IEnumerable<DistrictMasterMain>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<DistrictMasterMain>)StatusCode(StatusCodes.Status500InternalServerError,
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
