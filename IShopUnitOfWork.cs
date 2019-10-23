namespace RepositoryAndUnitOfWork

{
    public interface IShopUnitOfWork : IUnitlOfWork
    //eine konkrete Unit of work kennt alle repositories die notwendig sind  um darauf zu arbeiten, das heißt wir hätten hier eben ein ArticleRepository und InvoiceRepository
    // das alles was der Nutzer von Unit Of Work wissen mus, es gibt ArticleRepository damit kann man auf die ensprechenden Repo zugreifen und wenn man SaveChanges auf unit 
    //work aufruft dann werden diese Änderungen das entsprechende Medium das am repository hüngt mitübertragen
    //wenn man unity of work erstellt dann sind da auch die repositories mit dabei. man kann über die UOW auf Repositories zugreifen
    //diese Repositories werden über UOW zugänglich gemacht
    {
        IArticleRepository Articles { get; }
        IRepository<Invoice> Invoices { get; }
    }

}