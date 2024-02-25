using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;
using System.Data;

namespace Business.Concrete
{
    public class TransactionManager : ITransactionService
    {
        ITransactionDal _transactionDal;

        public TransactionManager(ITransactionDal transactionDal)
        {
            _transactionDal = transactionDal;
        }

        public void Add(Transaction transaction)
        {
            _transactionDal.Add(transaction);
        }

        public void Delete(Transaction transaction)
        {
            _transactionDal.Delete(transaction);
        }

        public List<Transaction> GetAll()
        {
            return _transactionDal.GetAll();
        }

        public List<Transaction> GetAllByAccount(int MusteriNO)
        {
            return _transactionDal.GetAll(t => t.AlacakHesapNO == MusteriNO || t.BorcluHesapNO == MusteriNO);
        }

        public List<Transaction> GetAllByType(int IslemTipi)
        {
            return _transactionDal.GetAll(t => t.IslemTipi == IslemTipi);
        }

        public void Update(Transaction transaction)
        {
            _transactionDal.Update(transaction);
        }

        public DataTable GetAllTransactions()
        {
            return _transactionDal.GetAllTransactions();
        }

        public DataTable GetTransactionsByType(int type)
        {
            return _transactionDal.GetTransactionsByType(type);
        }

        public DataTable GetTransactionsBySave(int save) 
        {
            return _transactionDal.GetTransactionsBySave(save);
        }

        public DataTable GetTransactionsByTypeAndSave(int type, int save)
        {
            return _transactionDal.GetTransactionsByTypeAndSave(type, save);
        }
    }
}