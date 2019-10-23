using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RepositoryAndUnitOfWork

{
    [Table("tblInvoices")]
    public class Invoice
    {
        [Key]
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public List<InvoiceItem> Items { get; set; }

    }

}