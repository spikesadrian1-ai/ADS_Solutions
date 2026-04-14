using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Intefaces
{
    public interface ITractOwnershipRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnerships();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnershipsByTractId(string TractId);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<TractOwnership>> RetrieveAllTractOwnershipsByLeaseId(string LeaseId);
    }
}
