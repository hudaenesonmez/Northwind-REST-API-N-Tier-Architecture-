using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Northwind.DataAccess.Abstract;
using Northwind.DataAccess.Context;
using Northwind.Entities.Concrete;

namespace Northwind.DataAccess.Concrete.EntityFramework
{
    public class EfOrderDetailDal : EfGenericRepositoryBase<OrderDetail>, IOrderDetailDal
    {
        public EfOrderDetailDal(NorthwindContext context) : base(context)
        {
        }
    }
}
