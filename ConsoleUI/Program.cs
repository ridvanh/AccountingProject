using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //AccountTest();
            //TransactionTest();
            //TransactionTest2();
        }

        private static void TransactionTest2()
        {
            TransactionManager transactionManager = new TransactionManager(new EFTransactionDal());

            foreach (var transaction in transactionManager.GetExpenseDetails())
            {
                Console.WriteLine(transaction.BorcluHesapNO + " " + transaction.MusteriNO + " " + transaction.IslemAciklamasi + " " + transaction.AlacakHesapNO + " " + transaction.IslemTutari);
            }
        }

        private static void TransactionTest()
        {
            TransactionManager transactionManager = new TransactionManager(new EFTransactionDal());

            foreach (var transaction in transactionManager.GetAllByType(2))
            {
                Console.WriteLine(transaction.IslemTarihi + " " + transaction.IslemTutari);
            }
        }

        private static void AccountTest()
        {
            AccountManager accountManager = new AccountManager(new EFAccountDal());

            foreach (var account in accountManager.GetAllByBalance(10000, 99999))
            {
                Console.WriteLine(account.Bakiye);
            }
        }
    }
}