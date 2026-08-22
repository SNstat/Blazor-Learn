using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blazor_Learn.Data.Entities;

public class Customer
{
    [Key]
    public int Id { get; set; }

    [Required, StringLength(250)]
    public string Name { get; set; }

    [Required]
    public int Age { get; set; }

    public DateTime CreatedDate { get; set; }

    // navigational property, just for LINQ later
    public virtual ICollection<Order> Orders { get; set; }

    // just for LINQ later
    [NotMapped]
    public bool HasOrders => Orders.Any();
}
