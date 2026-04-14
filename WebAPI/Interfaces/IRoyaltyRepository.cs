using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IRoyaltyRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<Royalty>> RetrieveAllRoyalties();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<Royalty>> SearchAllRoyaltiesByTractId(string TractId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractId"></param>
        /// <returns></returns>
        Task<IEnumerable<Royalty>> SearchAllRoyaltiesByLeaseId(string LeaseId);

    }
}
