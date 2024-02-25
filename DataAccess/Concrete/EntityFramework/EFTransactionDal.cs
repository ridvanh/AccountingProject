using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
    public class EFTransactionDal : EFEntityRepositoryBase<Transaction, OtoGaleriContext>, ITransactionDal
    {
        #region SQLMethodsFromInterface
        public DataTable GetAllTransactions()
        {
            throw new NotImplementedException();
        }

        public DataTable GetTransactionsBySave(int save)
        {
            throw new NotImplementedException();
        }

        public DataTable GetTransactionsByType(int type)
        {
            throw new NotImplementedException();
        }

        public DataTable GetTransactionsByTypeAndSave(int type, int save)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
