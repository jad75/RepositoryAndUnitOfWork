using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RepositoryAndUnitOfWork
{
    [Table("tblInvoiceItems")]
    public class InvoiceItem
    {
        [Key]
        public int ID { get; set; }
        public Article Article { get; set; }
        public int Quantity { get; set; }
    }
}