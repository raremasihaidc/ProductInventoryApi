using ProductsInventory.Model;

namespace ProductsInventory.DTOS
{
    public class ProductGruopDTOS :Product
    {
        public string ProductName { get; set; }
        public string ProductBaseGroup { get; set; }
        public int ProductGruopId { get; set; }
        public int ProductGroupCode { get; set; }

    }
}
