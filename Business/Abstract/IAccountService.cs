using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IAccountService
    {
        List<Account> GetAll();
        List<Account> GetAllByCustomer(int MusteriNO);
        List<Account> GetAllByCustomerAndBranch(int MusteriNO, int SubeNO);
        List<Account> GetAllByBalance(int min, int max);
        List<Account> GetAllByType(int type);
        Account GetByAccount(int HesapNO);
        int GetNextAccountAdditional(int MusteriNO, int SubeNO);
        void Add(Account account);
        void Update(Account account);
        void Delete(Account account);
        void UpdateBalance(Account account, int change);
    }
}