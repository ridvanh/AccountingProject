using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace DataAccess.Concrete.SQLServer
{
    public class SQLAccountDal : SQLBaseDal, IAccountDal
    {
        public SQLAccountDal() : base() { }
        
        public void Add(Account entity)
        {
            SqlCommand cmd = new SqlCommand("CreateAccount", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriNO", entity.MusteriNO);
            cmd.Parameters.AddWithValue("@SubeNO", entity.SubeNO);
            cmd.Parameters.AddWithValue("@EkNO", entity.EkNO);
            cmd.Parameters.AddWithValue("@Bakiye", 0);
            cmd.Parameters.AddWithValue("@HesapTuru", entity.HesapTuru);
            cmd.Parameters.AddWithValue("@HesapAciklamasi", entity.HesapAciklamasi);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(Account entity)
        {
            SqlCommand cmd = new SqlCommand("DeleteAccount", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriNO", entity.MusteriNO);
            cmd.Parameters.AddWithValue("@SubeNO", entity.SubeNO);
            cmd.Parameters.AddWithValue("@EkNO", entity.EkNO);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(Account entity)
        {
            SqlCommand cmd = new SqlCommand("UpdateAccount", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HesapNO", entity.HesapNO);
            cmd.Parameters.AddWithValue("@EkNO", entity.EkNO);
            cmd.Parameters.AddWithValue("@HesapTuru", entity.HesapTuru);
            cmd.Parameters.AddWithValue("@HesapAciklamasi", entity.HesapAciklamasi);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public int GetNextAdditional(int MusteriNO)
        {
            int result = -1;

            SqlCommand cmd = new SqlCommand("GetMaxAdditional", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@MusteriNO", MusteriNO);

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    if (reader.IsDBNull(0))
                    {
                        result = 0;
                    }
                    else
                    {
                        result = reader.GetInt32(0);
                    }
                }
            }
            conn.Close();

            return result + 1;
        }

        public void UpdateBalance(int HesapNO, int change)
        {
            SqlCommand cmd = new SqlCommand("UpdateBalance", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HesapNO", HesapNO);
            cmd.Parameters.AddWithValue("@Degisim", change);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Account GetByAccount(int HesapNO)
        {
            Account account = null;

            SqlCommand cmd = new SqlCommand("GetByAccount", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HesapNO", HesapNO);

            conn.Open();
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    account = new Account();
                    account.HesapNO = HesapNO;
                    account.MusteriNO = reader.GetInt32(1);
                    account.SubeNO = reader.GetInt32(2);
                    account.EkNO = reader.GetInt32(3);
                    account.Bakiye = reader.GetInt32(4);
                    account.HesapTuru = reader.GetInt32(5);
                    account.HesapAciklamasi = reader.GetString(6);
                }
            }
            conn.Close();

            return account;
        }

        public DataTable GetAllAccounts()
        {
            DataTable result = new DataTable();
            
            SqlCommand cmd = new SqlCommand("GetAllAccounts", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }
            conn.Close();
            
            return result;
        }

        public DataTable GetAccountsByType(int type)
        {
            DataTable result = new DataTable();

            SqlCommand cmd = new SqlCommand("GetAccountsByType", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@HesapTuru", type);

            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }
            conn.Close();

            return result;
        }

        #region EFMethodsFromInterface
        public Account Get(Expression<Func<Account, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Account> GetAll(Expression<Func<Account, bool>> filter = null)
        {
            Account account = new Account();

            throw new NotImplementedException();
        }
        #endregion
    }
}