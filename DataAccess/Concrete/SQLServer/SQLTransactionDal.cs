using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq.Expressions;

namespace DataAccess.Concrete.SQLServer
{
    public class SQLTransactionDal : SQLBaseDal, ITransactionDal
    {
        public SQLTransactionDal() : base() { }

        public void Add(Transaction entity)
        {
            SqlCommand cmd = new SqlCommand("CreateTransaction", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IslemTipi", entity.IslemTipi);
            cmd.Parameters.AddWithValue("@IslemAciklamasi", entity.IslemAciklamasi);
            cmd.Parameters.AddWithValue("@IslemTutari", entity.IslemTutari);
            cmd.Parameters.AddWithValue("@AlacakHesapNO", entity.AlacakHesapNO);
            cmd.Parameters.AddWithValue("@BorcluHesapNO", entity.BorcluHesapNO);
            cmd.Parameters.AddWithValue("@IslemTarihi", entity.IslemTarihi);
            cmd.Parameters.AddWithValue("@IslemiYapan", entity.IslemiYapan);
            cmd.Parameters.AddWithValue("@KayitDurumu", entity.KayitDurumu);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Delete(Transaction entity)
        {
            SqlCommand cmd = new SqlCommand("DeleteTransaction", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IslemNO", entity.IslemNO);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void Update(Transaction entity)
        {
            SqlCommand cmd = new SqlCommand("UpdateTransaction", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IslemNO", entity.IslemNO);
            cmd.Parameters.AddWithValue("@IslemTipi", entity.IslemTipi);
            cmd.Parameters.AddWithValue("@IslemAciklamasi", entity.IslemAciklamasi);
            cmd.Parameters.AddWithValue("@IslemiYapan", entity.IslemiYapan);
            cmd.Parameters.AddWithValue("@KayitDurumu", entity.KayitDurumu);

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public DataTable GetAllTransactions()
        {
            DataTable result = new DataTable();

            SqlCommand cmd = new SqlCommand("GetAllTransactions", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }
            conn.Close();

            return result;
        }

        public DataTable GetTransactionsByType(int type)
        {
            DataTable result = new DataTable();

            SqlCommand cmd = new SqlCommand("GetTransactionsByType", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IslemTipi", type);

            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }
            conn.Close();

            return result;
        }

        public DataTable GetTransactionsBySave(int save)
        {
            DataTable result = new DataTable();

            SqlCommand cmd = new SqlCommand("GetTransactionsBySave", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@KayitDurumu", save);

            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }
            conn.Close();

            return result;
        }

        public DataTable GetTransactionsByTypeAndSave(int type, int save)
        {
            DataTable result = new DataTable();

            SqlCommand cmd = new SqlCommand("GetTransactionsByTypeAndSave", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@IslemTipi", type);
            cmd.Parameters.AddWithValue("@KayitDurumu", save);

            conn.Open();
            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
            {
                adapter.Fill(result);
            }
            conn.Close();

            return result;
        }

        #region EFMethodsFromInterface
        public Transaction Get(Expression<Func<Transaction, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Transaction> GetAll(Expression<Func<Transaction, bool>> filter = null)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}