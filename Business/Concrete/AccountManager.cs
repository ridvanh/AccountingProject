using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System.Collections.Generic;
using System.Data;

namespace Business.Concrete
{
    public class AccountManager : IAccountService
    {
        IAccountDal _accountDal;

        public AccountManager(IAccountDal accountDal)
        {
            _accountDal = accountDal;
        }

        public void Add(Account account)
        {
            _accountDal.Add(account);
        }

        public void Delete(Account account)
        {
            _accountDal.Delete(account);
        }

        public List<Account> GetAll()
        {
            return _accountDal.GetAll();
        }

        public Account GetByAccount(int HesapNO)
        {
            // with EF
            //return _accountDal.Get(a => a.HesapNO == HesapNO);
            return _accountDal.GetByAccount(HesapNO);
        }

        public int GetNextAccountAdditional(int MusteriNO, int SubeNO)
        {
            // with EF
            //var accountList = GetAllByCustomerAndBranch(MusteriNO, SubeNO);

            //if (accountList.Count != 0)
            //{
            //    Account lastAccount = accountList[accountList.Count - 1];

            //    return lastAccount.EkNO + 1;
            //}
            //else
            //{
            //    return 1;
            //}

            return _accountDal.GetNextAdditional(MusteriNO);
        }

        public void Update(Account account)
        {
            _accountDal.Update(account);
        }

        public void UpdateBalance(Account account, int change)
        {
            _accountDal.UpdateBalance(account.HesapNO, change);
        }

        public DataTable GetAllAccounts()
        {
            return _accountDal.GetAllAccounts();
        }

        public DataTable GetAccountsByType(int type)
        {
            return _accountDal.GetAccountsByType(type);
        }

        #region EFMethods
        public List<Account> GetAllByBalance(int min, int max)
        {
            return _accountDal.GetAll(a => a.Bakiye >= min && a.Bakiye <= max);
        }

        public List<Account> GetAllByCustomer(int MusteriNO)
        {
            return _accountDal.GetAll(a => a.MusteriNO == MusteriNO);
        }

        public List<Account> GetAllByCustomerAndBranch(int MusteriNO, int SubeNO)
        {
            return _accountDal.GetAll(a => a.MusteriNO == MusteriNO && a.SubeNO == SubeNO);
        }

        public List<Account> GetAllByType(int type)
        {
            return _accountDal.GetAll(a => a.HesapTuru == type);
        }
        #endregion
    }
}
