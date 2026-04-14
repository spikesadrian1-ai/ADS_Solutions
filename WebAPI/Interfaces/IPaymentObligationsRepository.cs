using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public interface IPaymentObligationsRepository
    {
      /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<PaymentObligations>> RetrieveAllPayments();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        Task<IEnumerable<PaymentObligations>> SearchAllTractsPaymentByTractId(string TractId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="TractId"></param>
        /// <returns></returns>
        Task<IEnumerable<PaymentObligations>> SearchAllTractsPaymentByLeaseId(string LeaseId);

    }
}
