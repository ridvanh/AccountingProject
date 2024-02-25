using Core.DataAccess;
using Entities.Concrete;
using System.Data;

namespace DataAccess.Abstract
{
    public interface IAccountDal : IEntityRepository<Account>
    {
        int GetNextAdditional(int MusteriNO);
        void UpdateBalance(int HesapNO, int change);
        Account GetByAccount(int HesapNO);
        DataTable GetAllAccounts();
        DataTable GetAccountsByType(int type);
    }
}
