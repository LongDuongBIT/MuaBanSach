using System.ComponentModel.DataAnnotations.Schema;

namespace Mubasa.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }

        public int Quantity { get; set; }
        public double UnitPrice { get; set; }

        public int OrderHeaderId { get; set; }

        [ForeignKey("OrderHeaderId")]
        public OrderHeader OrderHeader { get; set; }

        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }
    }
}