namespace ProductsInventory.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBaseGroup { get; set; }
        public int ProductGruopId { get; set; }
        public int ProductGroupCode { get; set; }
        public int ProductPrice { get; set; }
        public string ProdcutExpireDate { get; set; }
        public int RecieptId { get; set; }
        public int ProductEntity { get; set; }
        public int RecieptCost { get; set; }
        public string RecieptDate { get; set; }
        public int VoucherId { get; set; }
        public string VoucherDate { get; set; }
        public string UserName { get; set; }
        public int UserPassword { get; set; }

    }
}
