﻿using Cau1.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau1.DAO
{
    public class AccountDAO : DBConnection
    {
        public List<AccountDTO> ReadAccount()
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("Get_Account", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<AccountDTO> lstAC = new List<AccountDTO>();
            while (reader.Read())
            {
                AccountDTO ac = new AccountDTO();
                ac.username = reader["username"].ToString();
                ac.displayname = reader["password"].ToString();
                ac.password = reader["displayname"].ToString();
                ac.type = reader["type"].ToString();
                
                lstAC.Add(ac);
            }
            conn.Close();
            return lstAC;
        }
        public void Add_Account(AccountDTO ac)
        {
            SqlConnection conn = CreateConnection();
            conn.Open();
            SqlCommand cmd = new SqlCommand("exec Add_Account @username, @displayname, @password, @type", conn);
            cmd.Parameters.Add(new SqlParameter("@username", ac.username));
            cmd.Parameters.Add(new SqlParameter("@displayname", ac.displayname));
            cmd.Parameters.Add(new SqlParameter("@password", ac.password));
            cmd.Parameters.Add(new SqlParameter("@type", ac.type));
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}
