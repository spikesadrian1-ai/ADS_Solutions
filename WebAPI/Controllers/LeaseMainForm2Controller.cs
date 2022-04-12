using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaseMainForm2Controller : ControllerBase
    {
        /// <summary>
        /// ADDED DATABASE LINK
        /// </summary>
        private readonly IConfiguration _context;
        //private readonly OGDatabaseSchemaV2Context _context1;

        /// <summary>
        /// ADDED CONNECTION TO CURRENT CONTROLLER
        /// </summary>
        /// <param name="context"></param>
        public LeaseMainForm2Controller(IConfiguration context)
        {
            _context = context;
        }

        //public LeaseMainForm2Controller(OGDatabaseSchemaV2Context context)
        //{
        //    _context1 = context;
        //}

        /////
        ///JSON RESULTS
        ////
        [HttpGet]
        public JsonResult Get()
        {

            string query = @"SELECT * FROM dbo.LeaseMainForm2";

            DataTable leaseTable = new DataTable();
            const string V = "DevConnection";
            string sqlDataSource = _context.GetConnectionString(V);
            System.Data.SqlClient.SqlDataReader leaseReader;
            using (System.Data.SqlClient.SqlConnection devCon = new System.Data.SqlClient.SqlConnection(sqlDataSource)) 
            {
                devCon.Open();
                using (System.Data.SqlClient.SqlCommand leaseCommand = new System.Data.SqlClient.SqlCommand(query, devCon))
                {              
                    leaseReader = leaseCommand.ExecuteReader();
                    leaseTable.Load(leaseReader);
                    leaseReader.Close();
                    devCon.Close();
                }
            } 

            return new JsonResult(leaseTable);

        }

        ///////
        /////JSON RESULTS
        //////
        //[HttpGet]
        //public JsonResult GetAll()
        //{

        //    string query = @"SELECT * FROM dbo.LeaseMainForm2";

        //    DataTable leaseTable = new DataTable();
        //    const string V = "DevConnection";
        //    string sqlDataSource = _context1.GetConnectionString(V);
        //    System.Data.SqlClient.SqlDataReader leaseReader;
        //    using (System.Data.SqlClient.SqlConnection devCon = new System.Data.SqlClient.SqlConnection(sqlDataSource))
        //    {
        //        devCon.Open();
        //        using (System.Data.SqlClient.SqlCommand leaseCommand = new System.Data.SqlClient.SqlCommand(query, devCon))
        //        {
        //            leaseReader = leaseCommand.ExecuteReader();
        //            leaseTable.Load(leaseReader);
        //            leaseReader.Close();
        //            devCon.Close();
        //        }
        //    }

        //    return new JsonResult(leaseTable);

        //}

        ///////
        /////JSON RESULTS
        //////
        //[HttpGet("{id}")]
        //public JsonResult GetByID()
        //{

        //    string query = @"SELECT * FROM dbo.LeaseMainForm2";

        //    DataTable leaseTable = new DataTable();
        //    const string V = "DevConnection";
        //    string sqlDataSource = _context.GetConnectionString(V);
        //    System.Data.SqlClient.SqlDataReader leaseReader;
        //    using (System.Data.SqlClient.SqlConnection devCon = new System.Data.SqlClient.SqlConnection(sqlDataSource))
        //    {
        //        devCon.Open();
        //        using (System.Data.SqlClient.SqlCommand leaseCommand = new System.Data.SqlClient.SqlCommand(query, devCon))
        //        {
        //            leaseReader = leaseCommand.ExecuteReader();
        //            leaseTable.Load(leaseReader);
        //            leaseReader.Close();
        //            devCon.Close();
        //        }
        //    }

        //    return new JsonResult(leaseTable);

        //}



        ///// <summary>
        ///// BY OWNER TABLE ID
        ///// </summary>
        //// GET api/<OwnerDetailsController>/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<LeaseMainForm2>> GetLeaseMainForm2Details(int id)
        //{
        //    var leaseMainForm2 = await _context1.LeaseMainForm2.FindAsync(id);

        //    if (leaseMainForm2 == null)
        //    {
        //        return NotFound();
        //    }

        //    return leaseMainForm2;
        //}
    }
}
