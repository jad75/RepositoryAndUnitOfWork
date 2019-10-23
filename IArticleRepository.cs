using System.Collections.Generic;

namespace RepositoryAndUnitOfWork
{
    public  interface IArticleRepository : IRepository<Article>
    {
    
        IList<Article> GetPremiumArticles(); // specifisch für diesen Repo
    }   
}
