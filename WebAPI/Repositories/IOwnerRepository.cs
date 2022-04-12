using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IOwnerRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public Task<IEnumerable<OwnerAddressesMain>> SearchOwners(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="tractid"></param>
        /// <returns></returns>
        Task<object> SearchOwners1(string name, string tractid);
    }
}
