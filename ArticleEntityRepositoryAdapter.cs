using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace RepositoryAndUnitOfWork

{
    public class ArticleEntityRepositoryAdapter : EntityRepositoryAdapter<Article>, IArticleRepository
    {
        public ArticleEntityRepositoryAdapter(DbSet<Article> dbSet) : base(dbSet)
        {

        }
        public IList<Article> GetPremiumArticles()
        {
            return DbSet.Where(article => article.Price >= 100.0m).ToList();
            
        }
    }

}