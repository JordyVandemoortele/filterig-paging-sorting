using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vives.Services.Model.Extensions
{
    public static class PagingExtensions
    {
        public static IQueryable<T> AddPaging<T>(this IQueryable<T> query, Paging paging)
        {
            if (paging.startIndex < 0)
            {
                paging.startIndex = 0;
            }
            if (paging.pageSize <= 0)
            {
                paging.pageSize = 10;
            }
            if (paging.pageSize > 1000)
            {
                paging.pageSize = 1000;
            }
            query =  query
                .Skip(paging.startIndex)
                .Take(paging.pageSize);
            return query;
        }
    }
}
