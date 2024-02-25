using Business.Concrete;
using DataAccess.Concrete.SQLServer;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Data;

namespace Business.Operations
{
    public class AccountOperations
    {
        private static AccountManager accountManagerSQL = new AccountManager(new SQLAccountDal());

        public static int AddAccountControl(string customerNo, string branchNo, object type)
        {
            if (Int32.Parse(customerNo) <= 0)
            {
                return 2;
            }
            else if (Int32.Parse(branchNo) <= 0)
            {
                return 3;
            }
            else if ((string)type == "")
            {
                return 4;
            }

            return 1;
        }
        
        public static void AddAccount(List<string> tBoxTexts, int comboIndex, string comboStr)
        {
            Account accountToAdd = new Account()
            {
                MusteriNO = Int32.Parse(tBoxTexts[0]),
                SubeNO = Int32.Parse(tBoxTexts[1]),
                EkNO = accountManagerSQL.GetNextAccountAdditional(Int32.Parse(tBoxTexts[0]), Int32.Parse(tBoxTexts[1])),
                Bakiye = 0,
                HesapTuru = comboIndex + 1,
                HesapAciklamasi = comboStr
            };

            accountManagerSQL.Add(accountToAdd);
        }

        public static int DeleteAccountControl(List<string> tBoxTexts)
        {
            if(tBoxTexts[0] == "")
            {
                return 2;
            }
            else if (Int32.Parse(tBoxTexts[5]) == 1)
            {
                return 3;
            }

            return 1;
        }

        public static void DeleteAccount(List<string> tBoxTexts)
        {
            Account accountToDelete = new Account()
            {
                HesapNO = Int32.Parse(tBoxTexts[0]),
                MusteriNO = Int32.Parse(tBoxTexts[1]),
                SubeNO = Int32.Parse(tBoxTexts[2]),
                EkNO = Int32.Parse(tBoxTexts[3]),
                Bakiye = Int32.Parse(tBoxTexts[4]),
                HesapTuru = Int32.Parse(tBoxTexts[5]),
                HesapAciklamasi = tBoxTexts[6]
            };

            accountManagerSQL.Delete(accountToDelete);
        }

        public static int UpdateAccountControl(List<string> tBoxTexts)
        {
            if (tBoxTexts[0] == "")
            {
                return 2;
            }
            else if (tBoxTexts[3] == "")
            {
                return 3;
            }
            else if (tBoxTexts[5] == "")
            {
                return 4;
            }
            else if (tBoxTexts[6] == "")
            {
                return 5;
            }
            
            return 1;
        }

        public static void UpdateAccount(List<string> tBoxTexts)
        {
            Account accountToUpdate = new Account()
            {
                HesapNO = Int32.Parse(tBoxTexts[0]),
                MusteriNO = Int32.Parse(tBoxTexts[1]),
                SubeNO = Int32.Parse(tBoxTexts[2]),
                EkNO = Int32.Parse(tBoxTexts[3]),
                Bakiye = Int32.Parse(tBoxTexts[4]),
                HesapTuru = Int32.Parse(tBoxTexts[5]),
                HesapAciklamasi = tBoxTexts[6]
            };

            accountManagerSQL.Update(accountToUpdate);
        }

        public static DataTable GetAccounts(int type)
        {
            switch (type)
            {
                case 1:
                    return accountManagerSQL.GetAccountsByType(3);
                case 2:
                    return accountManagerSQL.GetAccountsByType(2);
                case 3:
                    return accountManagerSQL.GetAccountsByType(1);
                default:
                    return accountManagerSQL.GetAllAccounts();
            }
        }
    }
}
