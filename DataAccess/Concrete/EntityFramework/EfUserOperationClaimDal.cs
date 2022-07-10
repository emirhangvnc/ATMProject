﻿using CoreLayer.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccessLayer.Concrete.Context;
using EntitiesLayer.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserOperationClaimDal : EfEntityRepositoryBase<UserOperationClaim, ATMContext>, IUserOperationClaimDal
    {
    }
}