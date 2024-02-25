using Entities.Concrete;
using Entities.DTOs;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ITransactionService
    {
        List<Transaction> GetAll();
        List<Transaction> GetAllByType(int IslemTipi);
        List<Transaction> GetAllByAccount(int MusteriNO);
        void Add(Transaction transaction);
        void Update(Transaction transaction);
        void Delete(Transaction transaction);
    }
}