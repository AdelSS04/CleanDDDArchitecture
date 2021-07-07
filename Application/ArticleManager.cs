using Application.Interfaces;
using Domaine.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class ArticleManager : IArticleManager
    {
        private List<Article> articles;
        public ArticleManager()
        {
            articles = new List<Article>();
        }
        public async Task AddArticle(Article article)
        {
            articles.Add(article);
        }

        public Article GetArticle(int id)
        {
            return articles.FirstOrDefault(x => x.Id == id);
        }

        public async Task RemoveArticle(Article article)
        {
            articles.Remove(article);
        }
        public List<Article> GetAll()
        {
            return articles.ToList();
        }
        public async Task EditArticle (Article article,string name)
        {
            articles.Remove(article);
            article.Name = name;
            articles.Add(article);
        }

    }
}
