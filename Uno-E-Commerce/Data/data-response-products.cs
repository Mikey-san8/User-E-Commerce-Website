namespace Uno_E_Commerce.Data
{
    public class dataProductsResponse
    {
        public required List<dataProducts> Products { get; set; }
        public int Total { get; set; }
        public int Skip { get; set; }
        public int Limit { get; set; }
    }
}
