using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebAPI.Repositories;

namespace WebAPI.Models
{
    public partial class CountyMasterMainForm : ICountyRepository
    {
        public int Id { get; set; }
        public string StateId { get; set; }
        public string CountyId { get; set; }
        public string CountyName { get; set; }

        public Task<object> GetAllCounties(int ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CountyMasterMainForm>> RetrieveAllCounties(string name)
        {
            throw new NotImplementedException();
        }

        public Task<object> SearchAllCounties(string name)
        {
            throw new NotImplementedException();
        }
    }
}
