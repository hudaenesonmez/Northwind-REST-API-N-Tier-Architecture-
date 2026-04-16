using Northwind.Entities.Abstract;

namespace Northwind.Entities.Concrete;

public  class CustomerDemographic:IEntity
{
    public string CustomerTypeId { get; set; } = null!;

    public string? CustomerDesc { get; set; }

    public virtual ICollection<Customer> Customers { get; set; } = new List<Customer>();
}
