using Domaine.Entites;
using Domaine.RepositoryInterfaces;
using Infrastructure.context;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class RepositoryProduct : IRepositoryProduct
    {
        private ClientContext clientContext;

        //private List<Article> InMemoryArticle;

        public RepositoryProduct(ClientContext clientContext)
        {
            this.clientContext = clientContext;
        }


        public Task AddAsync(Article entity)
        {
            clientContext.Add(entity);
            clientContext.SaveChanges();

            return Task.CompletedTask; 
        }

        public IEnumerable<Article> GetAll()
        {
            return clientContext.Articles.AsEnumerable();
        }

        public async Task<Article> UpdateAsync(Article entity)
        {
           var values = clientContext.Articles.Update(entity);
            await clientContext.SaveChangesAsync();
            return values.Entity;
        }

        public async Task UpdateRangeAsync(List<Article> entities)
        {
            clientContext.Articles.UpdateRange(entities);
            await clientContext.SaveChangesAsync();
        }
    }
}
