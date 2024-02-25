using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Data;

namespace DataAccess.Abstract
{
    public interface ITransactionDal : IEntityRepository<Transaction>
    {
        DataTable GetAllTransactions();
        DataTable GetTransactionsByType(int type);
        DataTable GetTransactionsBySave(int save);
        DataTable GetTransactionsByTypeAndSave(int type, int save);
    }
}
