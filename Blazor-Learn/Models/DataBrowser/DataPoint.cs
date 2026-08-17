namespace Blazor_Learn.Models.DataBrowser
{
    public class DataPoint
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; }

        public string ImageUrl { get; set; }
        public bool IsChecked { get; set; }
        public string GetStandardPriceValue() => Price.ToString("C2");

        public DataPoint(int id, string name, string description, double price, string imageUrl, bool isChecked)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            ImageUrl = imageUrl;
            IsChecked = isChecked;
        }
    }
}
