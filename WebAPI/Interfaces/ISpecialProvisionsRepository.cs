using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface ISpecialProvisionsRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisions();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisionsByTractId(string TractId);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SpecialProvisions>> RetrieveAllSpecialProvisionsByLeaseId(string LeaseId);

    }
}
