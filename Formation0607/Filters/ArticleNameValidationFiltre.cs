using Domaine.Entites;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Formation0607.Filters
{
    public class ArticleNameValidationFiltre : ActionFilterAttribute, IActionFilter
    {
        public  void OnActionExecuted(ActionExecutedContext context)
        {
   
        }

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            base.OnActionExecuting(context);
           // base.OnActionExecuting(context);
            var article=context.ActionArguments["article"] as Article;
            if(article != null && 
                string.IsNullOrWhiteSpace(article.Name) )
            {
                context.ModelState.AddModelError("ArticleName", "Article name is required.");
                context.Result = new BadRequestObjectResult(context.ModelState);
            }
        }
    }
}
