using LsAdmin.Domain.Entities;
using LsAdmin.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LsAdmin.EntityFrameworkCore.Repositories
{
    public class OrderMaterialRepository : LsAdminRepositoryBase<OrderMaterial>, IOrderMaterialRepository {
        public OrderMaterialRepository(LsAdminDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
