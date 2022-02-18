﻿using LsAdmin.Domain.Entities;
using LsAdmin.Domain.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace LsAdmin.EntityFrameworkCore.Repositories
{
    public class PlaceTypeRepository : LsAdminRepositoryBase<PlaceType>, IPlaceTypeRepository
    {
        public PlaceTypeRepository(LsAdminDbContext dbcontext) : base(dbcontext)
        {

        }
    }
}
