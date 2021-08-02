using Domaine.Entites;
using Domaine.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RepositoryProduct : IRepositoryProduct
    {
        public Task<Article> AddAsync(Article entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Article> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Article> UpdateAsync(Article entity)
        {
            throw new NotImplementedException();
        }

        public Task UpdateRangeAsync(List<Article> entities)
        {
            throw new NotImplementedException();
        }
    }
}
