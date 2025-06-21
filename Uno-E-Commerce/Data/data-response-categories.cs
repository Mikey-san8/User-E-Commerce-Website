namespace Uno_E_Commerce.Data
{
    public class CategoryGroup
    {
        public string GroupName { get; set; } = string.Empty;
        public List<dataCategoriesResponse> Categories { get; set; } = new();
    }

    public class dataCategoriesResponse
    {
        public string Slug { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;
    }
    public class CategoryImage
    {
        public string Category { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = "https://via.placeholder.com/300x200";
    }
}
