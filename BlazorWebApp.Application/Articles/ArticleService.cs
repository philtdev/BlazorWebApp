using BlazorWebApp.Domain.Articles;

namespace BlazorWebApp.Application.Articles;

public class ArticleService : IArticleService
{
    public List<Article> GetArticles()
    {
        return
        [
            new() {
                Id = 1,
                Title = "First Article",
                Content = "This is the content of the first article",
                DatePublished = DateTime.Now.AddDays(-1),
                IsPublished = true
            },
            new() {
                Id = 2,
                Title = "Second Article",
                Content = "This is the content of the second article",
                DatePublished = DateTime.Now.AddDays(-2),
                IsPublished = true
            },
            new() {
                Id = 3,
                Title = "Third Article",
                Content = "This is the content of the third article",
                DatePublished = DateTime.Now.AddDays(-3),
                IsPublished = true
            }
        ];
    }
}
