using Northwind.Entities.Abstract;

namespace Northwind.Entities.Concrete;

public  class Region:IEntity
{
    public int RegionId { get; set; }

    public string RegionDescription { get; set; } = null!;

    public virtual ICollection<Territory> Territories { get; set; } = new List<Territory>();
}
