using System;

namespace RepositoryAndUnitOfWork

{
    public class ShopUnitOfWorkDbContextAdapter : IShopUnitOfWork
    {
        private readonly ShopDbContext        _shopDbContext;
        private readonly IArticleRepository   _articleRepository ;
        private readonly IRepository<Invoice> _invoiceRepository;

        public IArticleRepository Articles
        {
            get { return _articleRepository; }
        }

        public IRepository<Invoice> Invoices
        {
            get { return _invoiceRepository; }
        }
        public ShopUnitOfWorkDbContextAdapter(   ShopDbContext shopDbContext,        
                                                 IArticleRepository articleRepository,
                                                 IRepository< Invoice > invoiceRepository)
        {
            if (shopDbContext == null) throw new ArgumentNullException("shopDbcontext");
            if (articleRepository == null) throw new ArgumentNullException("articleRepository");
            if (invoiceRepository == null) throw new ArgumentNullException("invoiceRepository");

            _shopDbContext = shopDbContext;
            _articleRepository = articleRepository;
            _invoiceRepository = invoiceRepository;


        }

        public void SaveChanges()
        {
            _shopDbContext.SaveChanges();
        }
    }

}