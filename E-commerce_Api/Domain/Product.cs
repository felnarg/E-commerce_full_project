namespace Domain
{
    public class Product
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public string? CategoryId { get; set; }
        public float? Price { get; set; }
        public string? Image {  get; set; }
        public string? Stock { get; set; }
        public string? Sku { get; set; }
        public float? Weight { get; set; }
        public float? High { get; set; }
        public float? Length { get; set; }
        public float? Width { get; set; }
        public bool? Availability { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? LastUpdateDate { get; set; }
        public Category? CategoryModel { get; set; }
    }
}
