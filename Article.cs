using System;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepositoryAndUnitOfWork
{
    [Table("tblArticles")]
    public class Article
    {
        [Key]
        public int ID { get; set; }
        public string Name  { get; set; }
        public Decimal Price { get; set; }
    }
}
