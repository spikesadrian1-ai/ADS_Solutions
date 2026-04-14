using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Intefaces
{
    public interface ICountyRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<CountyMasterMainForm>> RetrieveAllCounties();


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> GetCountiesByID(string CountyID);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<object> SearchAllCounties(string name);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        Task<CountyMasterMainForm> AddNewCounty(CountyMasterMainForm countyMasterMainForm);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        Task<CountyMasterMainForm> UpdateCounty(CountyMasterMainForm countyMasterMainForm);


        /// <summary>
        /// 
        /// </summary>
        /// <param name="countyMasterMainForm"></param>
        /// <returns></returns>
        Task<CountyMasterMainForm> DeleteCounty(CountyMasterMainForm countyMasterMainForm);
    }
}
