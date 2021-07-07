using Domaine.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IArticleManager
    {
        Task AddArticle(Article article);
        Article GetArticle(int id);
        Task RemoveArticle(Article article);
        List<Article> GetAll();
        Task EditArticle(Article article, string name);
    }
}
