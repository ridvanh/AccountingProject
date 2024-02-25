using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryAccountDal : IAccountDal
    {
        List<Account> _accounts;

        public InMemoryAccountDal()
        {
            _accounts = new List<Account> {
                new Account{HesapNO=1, MusteriNO=1, SubeNO=1, EkNO=1, Bakiye=10000, HesapTuru=1, HesapAciklamasi="Şirket"},
                new Account{HesapNO=2, MusteriNO=1, SubeNO=1, EkNO=2, Bakiye=8000, HesapTuru=1, HesapAciklamasi="Şirket"},
                new Account{HesapNO=3, MusteriNO=2, SubeNO=1, EkNO=1, Bakiye=20000, HesapTuru=2, HesapAciklamasi="Çalışan"},
                new Account{HesapNO=4, MusteriNO=3, SubeNO=1, EkNO=1, Bakiye=30000, HesapTuru=3, HesapAciklamasi="Müşteri"},
                new Account{HesapNO=5, MusteriNO=3, SubeNO=2, EkNO=2, Bakiye=5000, HesapTuru=3, HesapAciklamasi="Müşteri"}
            };
        }
        public void Add(Account account)
        {
            _accounts.Add(account);
        }

        public void Delete(Account account)
        {
            Account accountToDelete = _accounts.SingleOrDefault(a => a.HesapNO == account.HesapNO);

            _accounts.Remove(accountToDelete);
        }

        public List<Account> GetAll()
        {
            return _accounts;
        }

        public List<Account> GetAllByCustomer(int MusteriNO)
        {
            return _accounts.Where(a => a.MusteriNO == MusteriNO).ToList();
        }

        public void Update(Account account)
        {
            Account accountToUpdate = _accounts.SingleOrDefault(a => a.HesapNO == account.HesapNO);
            accountToUpdate.MusteriNO = account.MusteriNO;
            accountToUpdate.SubeNO = account.SubeNO;
            accountToUpdate.EkNO = account.EkNO;
            accountToUpdate.Bakiye = account.Bakiye;
            
        }

        #region NotImplementedMethods
        public Account Get(Expression<Func<Account, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public DataTable GetAccountsByType(int type)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll(Expression<Func<Account, bool>> filter = null)
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
