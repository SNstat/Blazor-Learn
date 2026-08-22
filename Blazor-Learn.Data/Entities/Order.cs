using System.ComponentModel.DataAnnotations;

namespace Blazor_Learn.Data.Entities;

public class Order
{
    [Key]
    public int Id { get; set; }

    public string? ItemDescription { get; set; }

    [Required]
    public int Quantity { get; set; }

    // just for LINQ later
    [Required]
    public int CustomerId { get; set; }

    // navigational property
    public virtual Customer Customer { get; set; }
}
