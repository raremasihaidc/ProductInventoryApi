using ProductsInventory.Model;

namespace ProductsInventory.DTOS
{
    public class VoucherDTOS : Product
    {
        public int VoucherId { get; set; }
        public string VoucherDate { get; set; }
        public int ProductPrice { get; set; }
        public int ProductEntity { get; set; }
        public int ProductId { get; set; }
    }
}
