﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace SqlQueryClass
{
    class DataHelper
    {
        SqlConnection sqlConnection = new SqlConnection();

        public DataTable GetResults(string sqlQuery)
        {
            OpenSqlConn();

            DataTable DtResult = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlConnection);
            sqlDataAdapter.Fill(DtResult);

            return DtResult;
        }

        public DataTable PostValues(string sqlQuery)
        {
            OpenSqlConn();
            SqlCommand sqlCommand = new SqlCommand(sqlQuery, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            return null;
        }

        

        private void OpenSqlConn()
        {
            if (sqlConnection.State != ConnectionState.Open)
            {
                sqlConnection.ConnectionString = @"Data Source = DESKTOP-0GG26R8; Initial Catalog = StudentsData; Integrated Security=True";
                sqlConnection.Open();
            }
        }
    }
}