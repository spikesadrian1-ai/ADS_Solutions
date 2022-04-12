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
    public class PaymentObligationsController : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly OGDatabaseSchemaV2Context _context;


        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public PaymentObligationsController(OGDatabaseSchemaV2Context context)
        {
            _context = context;
        }

        /// <summary>
        /// ALL PaymentObligations
        /// CREATE ASYNC METHOD
        /// </summary>
        // GET: api/<PaymentObligationsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PaymentObligations>>> RetrieveAllPaymentObligations()
        {
            return await _context.PaymentObligations.ToListAsync();

        }


        /// <summary>
        /// BY PaymentObligations TABLE ID
        /// </summary>
        [HttpGet("GetAllPaymentObligations/{id}")]
        public async Task<ActionResult<PaymentObligations>> GetAllPaymentObligations(int id)
        {
            var burdens = await _context.PaymentObligations.FindAsync(id);

            if (burdens == null)
            {
                return NotFound();
            }

            return burdens;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        [HttpGet("{SearchAllPaymentObligations}")]
        public async Task<IEnumerable<PaymentObligations>> SearchAllPaymentObligations(string name)
        {
            try
            {
                var result = await SearchAllPaymentObligations(name);

                if (result.Any())
                {
                    return (IEnumerable<PaymentObligations>)Ok(result);
                }

                return (IEnumerable<PaymentObligations>)NotFound();
            }
            catch (Exception)
            {
                return (IEnumerable<PaymentObligations>)StatusCode(StatusCodes.Status500InternalServerError,
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
