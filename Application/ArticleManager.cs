using Application.Interfaces;
using Domaine.Entites;
using Domaine.RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ArticleManager : IArticleManager
    {
        private readonly IRepositoryProduct repositoryProduct;

        public ArticleManager(IRepositoryProduct repositoryProduct)
        {
            this.repositoryProduct = repositoryProduct;
        }
        public async Task AddArticle(Article article)
        {
            repositoryProduct.AddAsync(article);
        }

        public Article GetArticle(int id)
        {
            return GetAll().FirstOrDefault(x => x.Id == id);
        }

        public async Task RemoveArticle(Article article)
        {
            GetAll().Remove(article);
        }
        public List<Article> GetAll()
        {
            return repositoryProduct.GetAll().ToList();
        }
        public async Task EditArticle (Article article,string name)
        {
           

        }

    }
}
