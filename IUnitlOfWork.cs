namespace RepositoryAndUnitOfWork

{
    public interface IUnitlOfWork
    {
        void SaveChanges(); //damit werden alle änderungen die an die Repositories gemacht worden mit add and remove übertragen und jetzt kommt eben der clou
                            
    }

}