using System.ComponentModel.DataAnnotations;

namespace PracticaCalificada1.Models
{
    public class Sale
    {
        [Key]
        public int SalesID { get; set; }
        public int SalesPersonId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
    }
}
