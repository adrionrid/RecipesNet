using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RecipesNet
{
    public class PaginatedList<T> : List<T>
    {
        public Pagination Pagination { get; private set; }

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            Pagination = new Pagination(count, pageIndex, pageSize);

            this.AddRange(items);
        }

        public static async Task<PaginatedList<T>> CreateAsync(
            IQueryable<T> source, int pageIndex, int pageSize)
        {
            var count = await source.CountAsync();
            var items = await source.Skip(
                (pageIndex - 1) * pageSize)
                .Take(pageSize).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, pageSize);
        }

        internal object DishType()
        {
            throw new NotImplementedException();
        }
    }
}
