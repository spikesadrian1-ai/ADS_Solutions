using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface ISurfaceOwnershipRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnerships();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnershipsByTractId(string TractId);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<SurfaceOwnership>> RetrieveAllSurfaceOwnershipsByLeaseId(string LeaseId);

    }
}
