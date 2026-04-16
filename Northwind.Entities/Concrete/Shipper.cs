using Northwind.Entities.Abstract;

namespace Northwind.Entities.Concrete;

public  class Shipper:IEntity
{
    public int ShipperId { get; set; }

    public string CompanyName { get; set; } = null!;

    public string? Phone { get; set; }

    public virtual ICollection<Order> Orders { get; set; } = new List<Order>();
}
