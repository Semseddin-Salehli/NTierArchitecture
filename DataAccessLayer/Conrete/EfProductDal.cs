using CoreLayer.DataAccess.EntityFramework;
using DataAccessLayer.Abstract;
using EntityLayer.Conrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Conrete
{
    public class EfProductDal : EfEntityRepositoryBase<Product, KatmanliContext>, IProductDal
    {

    }
}
