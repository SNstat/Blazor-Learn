namespace Blazor_Learn.Models.DataBrowser
{
    public class DataService
    {
        public async Task<List<DataPoint>> GetDataPointsAsync()
        {
            var dataPoints = new List<DataPoint>();
            dataPoints.AddRange(
                new DataPoint(1, "Margherita", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/a/a3/Eq_it-na_pizza-margherita_sep2005_sml.jpg?utm_source=commons.wikimedia.org&utm_campaign=index&utm_content=original", false),
                new DataPoint(2, "Neopolitan", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/c/c7/Margherita_pizza_at_A16_San_Francisco.jpg", false),
                new DataPoint(3, "Sicilian", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/e/e9/Sicilian_slice_-_Carmine%27s_Original_Pizza.jpg", false),
                new DataPoint(4, "New York Style", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/d/d9/New_York-Style_Pizza-crop.png", false),
                new DataPoint(5, "Chicago Deep-Dish", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/7/77/Chicago-style_Pizza_Pie.jpg", false),
                new DataPoint(6, "Veggie Pizza", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/7/7b/Vegetarian-pizza-top.jpg", false),
                new DataPoint(7, "Roman Style", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/d/d9/New_York-Style_Pizza-crop.png", false),
                new DataPoint(8, "Pepperoni Pizza", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/7/77/Chicago-style_Pizza_Pie.jpg", false),
                new DataPoint(9, "Grandma Pizza", "Dough, Tomato and Cheese!", 13.2345, "https://upload.wikimedia.org/wikipedia/commons/e/e9/Sicilian_slice_-_Carmine%27s_Original_Pizza.jpg", false)
                );
            return dataPoints;
        }
    }
}
