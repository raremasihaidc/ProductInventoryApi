using ProductsInventory.Model;

namespace ProductsInventory.DTOS
{
    public class ProductDTOS:Product
    {
        public string ProductName { get; set; }
        public int ProductId { get; set; }
        public int ProductPrice { get; set; }
        public string ProdcutExpireDate { get; set; }
        public int ProductGruopId { get; set; }
    }
}
