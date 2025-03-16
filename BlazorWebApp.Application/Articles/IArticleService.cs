using BlazorWebApp.Domain.Articles;

namespace BlazorWebApp.Application.Articles;

public interface IArticleService
{
    List<Article> GetArticles();
}
