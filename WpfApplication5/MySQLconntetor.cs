using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace LoginIndicator
{
    class MySQLconntetor
    {
        public static string SQLconnect(string A,string B)
        {
            string Suc = "";
            string dbHost = "106.187.95.13"; //"資料庫位址"
            string dbUser = "PPC"; //"資料庫使用者名稱"
            string dbPass = "PPC"; //"資料庫使用者密碼"
            string dbName = "PPC_AC"; //"資料庫名稱"

            // 如果有特殊的編碼在database後面請加上;CharSet=編碼, utf8請使用utf8_general_ci
            string connStr = "server=" + dbHost + ";uid=" + dbUser + ";pwd=" + dbPass + ";database=" + dbName;
            MySqlConnection conn = new MySqlConnection(connStr);

            // 連線到資料庫
            try
            {
                conn.Open();
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("無法連線到資料庫.");
                        break;
                    case 1045:
                        Console.WriteLine("使用者帳號或密碼錯誤,請再試一次.");
                        break;
                }
            }
         
            string SQL = "select 1 from PPC_AC where ID=@User and PW=@Pass";
            try
            {
                MySqlCommand cmd = new MySqlCommand(SQL, conn);
                cmd.Parameters.AddWithValue("@User", A);
                cmd.Parameters.AddWithValue("@Pass", B);
                object ret = cmd.ExecuteScalar();
               // MySqlDataReader myData = cmd.ExecuteReader();
                if (ret != null && ret != DBNull.Value)
                {
                    Console.WriteLine("Login Successful");
                    Suc = "Success";
                }
                else 
                {
                    Console.WriteLine("Error ");
                    Suc = "Fail";
                }
            }
            catch (MySql.Data.MySqlClient.MySqlException ex) 
            {
                Console.WriteLine("Error " + ex.Number + " : " + ex.Message);
            }

            return Suc;
        }

    }
}
