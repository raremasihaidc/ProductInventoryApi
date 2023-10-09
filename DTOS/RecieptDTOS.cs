using ProductsInventory.Model;

namespace ProductsInventory.DTOS
{
    public class RecieptDTOS :Product
    {
        public int RecieptId { get; set; }
        public int RecieptCost { get; set; }
        public string RecieptDate { get; set; }
        public int ProductPrice { get; set; }
        public int ProductEntity { get; set; }
        public int ProductId { get; set; }
    }
}
