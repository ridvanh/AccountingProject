using Business.Concrete;
using DataAccess.Concrete.SQLServer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business.Operations
{
    public class TransactionOperations
    {
        private static TransactionManager transactionManagerSQL = new TransactionManager(new SQLTransactionDal());
        private static AccountManager accountManagerSQL = new AccountManager(new SQLAccountDal());

        public static int GeneralPaymentControl(int payment, object type, int accountNo)
        {
            if ((string)type == "")
            {
                return 3;
            }
            else if (payment < 0)
            {
                return 2;
            }
            else if (accountManagerSQL.GetByAccount(accountNo) == null)
            {
                return 4;
            }

            return 1;
        }

        public static int DepositSalaryControl(string accNo)
        {
            Account accountToControl = accountManagerSQL.GetByAccount(Int32.Parse(accNo));

            if (accountToControl.HesapTuru != 2)
            {
                return 2;
            }

            return 1;
        }

        public static void DepositSalary(List<string> tBoxTexts)
        {
            Account accountToUpdate = accountManagerSQL.GetByAccount(Int32.Parse(tBoxTexts[0]));

            Transaction transactionToAdd = new Transaction()
            {
                IslemTipi = 1,
                IslemAciklamasi = "Maaş",
                IslemTutari = Int32.Parse(tBoxTexts[1]),
                AlacakHesapNO = Int32.Parse(tBoxTexts[0]),
                BorcluHesapNO = 1,
                IslemTarihi = DateTime.Now,
                IslemiYapan = 1,
                KayitDurumu = 1
            };

            accountManagerSQL.UpdateBalance(accountToUpdate, transactionToAdd.IslemTutari);
            transactionManagerSQL.Add(transactionToAdd);
        }

        public static int DepositCarSaleControl(string accNo, object brand)
        {
            Account accountToControl = accountManagerSQL.GetByAccount(Int32.Parse(accNo));

            if ((string)brand == "")
            {
                return 3;
            }
            else if (accountToControl.HesapTuru == 1)
            {
                return 2;
            }

            return 1;
        }

        public static void DepositCarSale(List<string> tBoxTexts, string brand)
        {
            int brandAccount = 1;

            switch (brand)
            {
                case "Mercedes":
                    brandAccount = 1003;
                    break;
                case "BMW":
                    brandAccount = 1004;
                    break;
                case "Audi":
                    brandAccount = 1005;
                    break;
                default:
                    break;
            }

            Account accountToUpdate = accountManagerSQL.GetByAccount(Int32.Parse(tBoxTexts[0]));

            Transaction transactionToAdd = new Transaction()
            {
                IslemTipi = 2,
                IslemAciklamasi = "Araç Satış",
                IslemTutari = Int32.Parse(tBoxTexts[1]),
                AlacakHesapNO = brandAccount,
                BorcluHesapNO = Int32.Parse(tBoxTexts[0]),
                IslemTarihi = DateTime.Now,
                IslemiYapan = 1,
                KayitDurumu = 1
            };

            accountManagerSQL.UpdateBalance(accountToUpdate, -transactionToAdd.IslemTutari);
            accountManagerSQL.UpdateBalance(accountManagerSQL.GetByAccount(brandAccount), transactionToAdd.IslemTutari);
            transactionManagerSQL.Add(transactionToAdd);
        }

        public static int DepositServicePaymentControl(string accNo)
        {
            Account accountToControl = accountManagerSQL.GetByAccount(Int32.Parse(accNo));

            if (accountToControl.HesapTuru == 1)
            {
                return 2;
            }

            return 1;
        }

        public static void DepositServicePayment(List<string> tBoxTexts)
        {
            Account accountToUpdate = accountManagerSQL.GetByAccount(Int32.Parse(tBoxTexts[0]));

            Transaction transactionToAdd = new Transaction()
            {
                IslemTipi = 3,
                IslemAciklamasi = "Servis",
                IslemTutari = Int32.Parse(tBoxTexts[1]),
                AlacakHesapNO = 2,
                BorcluHesapNO = Int32.Parse(tBoxTexts[0]),
                IslemTarihi = DateTime.Now,
                IslemiYapan = 1,
                KayitDurumu = 1
            };

            accountManagerSQL.UpdateBalance(accountToUpdate, -transactionToAdd.IslemTutari);
            accountManagerSQL.UpdateBalance(accountManagerSQL.GetByAccount(2), transactionToAdd.IslemTutari);
            transactionManagerSQL.Add(transactionToAdd);
        }

        public static void DepositOtherPayment(List<string> tBoxTexts)
        {
            Account accountToUpdate = accountManagerSQL.GetByAccount(Int32.Parse(tBoxTexts[0]));

            Transaction transactionToAdd = new Transaction()
            {
                IslemTipi = 4,
                IslemAciklamasi = "Diğer",
                IslemTutari = Int32.Parse(tBoxTexts[1]),
                AlacakHesapNO = 1,
                BorcluHesapNO = Int32.Parse(tBoxTexts[0]),
                IslemTarihi = DateTime.Now,
                IslemiYapan = 1,
                KayitDurumu = 1
            };

            accountManagerSQL.UpdateBalance(accountToUpdate, -transactionToAdd.IslemTutari);
            accountManagerSQL.UpdateBalance(accountManagerSQL.GetByAccount(1), transactionToAdd.IslemTutari);
            transactionManagerSQL.Add(transactionToAdd);
        }
        
        public static int UpdateTransactionControl(List<string> tBoxTexts)
        {
            if (tBoxTexts[0] == "")
            {
                return 2;
            }
            else if (tBoxTexts[7] == "")
            {
                return 3;
            }
            else if (tBoxTexts[8] == "")
            {
                return 4;
            }

            return 1;
        }

        public static void UpdateTransaction(List<string> tBoxTexts)
        {
            Transaction transactionToUpdate = new Transaction()
            {
                IslemNO = Int32.Parse(tBoxTexts[0]),
                IslemTipi = Int32.Parse(tBoxTexts[1]),
                IslemAciklamasi = tBoxTexts[2],
                IslemTutari = Int32.Parse(tBoxTexts[3]),
                AlacakHesapNO = Int32.Parse(tBoxTexts[4]),
                BorcluHesapNO = Int32.Parse(tBoxTexts[5]),
                IslemTarihi = DateTime.Parse(tBoxTexts[6]),
                IslemiYapan = Int32.Parse(tBoxTexts[7]),
                KayitDurumu = Int32.Parse(tBoxTexts[8])
            };

            transactionManagerSQL.Update(transactionToUpdate);
        }

        public static int DeleteTransactionControl(List<string> tBoxTexts)
        {
            if (tBoxTexts[0] == "")
            {
                return 2;
            }

            return 1;
        }

        public static void DeleteTransaction(List<string> tBoxTexts) 
        {
            Transaction transactionToUpdate = new Transaction()
            {
                IslemNO = Int32.Parse(tBoxTexts[0]),
                IslemTipi = Int32.Parse(tBoxTexts[1]),
                IslemAciklamasi = tBoxTexts[2],
                IslemTutari = Int32.Parse(tBoxTexts[3]),
                AlacakHesapNO = Int32.Parse(tBoxTexts[4]),
                BorcluHesapNO = Int32.Parse(tBoxTexts[5]),
                IslemTarihi = DateTime.Parse(tBoxTexts[6]),
                IslemiYapan = Int32.Parse(tBoxTexts[7]),
                KayitDurumu = 0
            };

            transactionManagerSQL.Update(transactionToUpdate);
        }

        public static DataTable GetTransactions(int typeIndex, int saveIndex)
        {
            switch (typeIndex)
            {
                case 0:
                    switch (saveIndex)
                    {
                        case 0:
                            return transactionManagerSQL.GetAllTransactions();
                        case 1:
                            return transactionManagerSQL.GetTransactionsBySave(0);
                        case 2:
                            return transactionManagerSQL.GetTransactionsBySave(1);
                        default:
                            return transactionManagerSQL.GetAllTransactions();
                    }
                case 1:
                    switch (saveIndex)
                    {
                        case 0:
                            return transactionManagerSQL.GetTransactionsByType(1);
                        case 1:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(1, 0);
                        case 2:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(1, 1);
                        default:
                            return transactionManagerSQL.GetTransactionsByType(1);
                    }
                case 2:
                    switch (saveIndex)
                    {
                        case 0:
                            return transactionManagerSQL.GetTransactionsByType(2);
                        case 1:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(2, 0);
                        case 2:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(2, 1);
                        default:
                            return transactionManagerSQL.GetTransactionsByType(2);
                    }
                case 3:
                    switch (saveIndex)
                    {
                        case 0:
                            return transactionManagerSQL.GetTransactionsByType(3);
                        case 1:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(3, 0);
                        case 2:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(3, 1);
                        default:
                            return transactionManagerSQL.GetTransactionsByType(3);
                    }
                case 4:
                    switch (saveIndex)
                    {
                        case 0:
                            return transactionManagerSQL.GetTransactionsByType(4);
                        case 1:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(4, 0);
                        case 2:
                            return transactionManagerSQL.GetTransactionsByTypeAndSave(4, 1);
                        default:
                            return transactionManagerSQL.GetTransactionsByType(4);
                    }
                default:
                    switch (saveIndex)
                    {
                        case 0:
                            return transactionManagerSQL.GetAllTransactions();
                        case 1:
                            return transactionManagerSQL.GetTransactionsBySave(0);
                        case 2:
                            return transactionManagerSQL.GetTransactionsBySave(1);
                        default:
                            return transactionManagerSQL.GetAllTransactions();
                    }
            }
        }
    }
}
