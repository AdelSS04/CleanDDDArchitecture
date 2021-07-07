using Application.Interfaces;
using Domaine.Entites;
using Formation0607.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formation0607.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IArticleManager articleManager;

        public ProductController(IArticleManager articleManager)
        {
            this.articleManager = articleManager;
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var Article = articleManager.GetArticle(id);
            if (Article == null)
                return NotFound("Article Doesnt exist");
            articleManager.RemoveArticle(Article);
            return Ok("Product Deleted");
        }
        [HttpGet("{id}")]
        public ActionResult<Article> GetArticle(int id)
        {
            var article = articleManager.GetArticle(id);

            return article == null ? NotFound() : Ok(article);

        }
        [HttpPost]
        [ArticleNameValidationFiltre]
        public IActionResult CreateArticle(Article article)
        {
            if (articleManager.GetArticle(article.Id) != null)
                return new JsonResult("Article exist");
            articleManager.AddArticle(article);
            return Ok("Product Add");
        }
        [HttpGet]
        public ActionResult<List<Article>> GetAll()
        {
            var article = articleManager.GetAll();
            return article.Count == 0 ? NoContent() : Ok(article);
        }
        [HttpPut("{id}")]
        public ActionResult<List<Article>> GetAll(int id, [FromBody] string name)
        {
            var article = articleManager.GetArticle(id);

            if (article == null)
                return new JsonResult("Article exist");

            articleManager.EditArticle(article, name);
            return Ok(article);
        }

    }
}
