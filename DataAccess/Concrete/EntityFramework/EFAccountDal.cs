using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFAccountDal : EFEntityRepositoryBase<Account, OtoGaleriContext>, IAccountDal
    {
        #region SQLMethodsFromInterface
        public DataTable GetAccountsByType(int type)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAllAccounts()
        {
            throw new NotImplementedException();
        }

        public Account GetByAccount(int HesapNO)
        {
            throw new NotImplementedException();
        }

        public int GetNextAdditional(int MusteriNO)
        {
            throw new NotImplementedException();
        }

        public void UpdateBalance(int HesapNO, int change)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
