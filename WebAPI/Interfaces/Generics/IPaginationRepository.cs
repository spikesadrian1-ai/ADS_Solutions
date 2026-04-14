using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models.zPagination;

namespace WebAPI.Intefaces.Generics
{
    public interface IPaginationRepository<T>
    {
        Task<ActionResult<List<T>>> RetrieveByPageN([FromQuery] PaginationDTO T);

    }
}
