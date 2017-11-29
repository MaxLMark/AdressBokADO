﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdressBok.DAL
{

    internal class DataAccess
    {
        private SqlConnection conn = null;

        public DataAccess()
        {
            var connectionString = Properties.Settings.Default.AdressBokConnection;
            conn = new SqlConnection(connectionString);
        }

        public bool ExecuteNonQuery(string CommandText, CommandType cmdType, SqlParameter[] param)
        {
            SqlCommand cmd = null;
            int res = 0;

            cmd = conn.CreateCommand();


            cmd.CommandType = cmdType;
            cmd.CommandText = CommandText;
            cmd.Parameters.AddRange(param);

            try
            {
                conn.Open();

                res = cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                cmd.Dispose();
                cmd = null;
                conn.Close();
            }

            if (res >= 1)
            {
                return true;

            }
            else
            {
                return false;
            }


        }

        public DataSet ExecuteSelectCommand(string Commandtext, CommandType cmdType)
        {
            SqlCommand cmd = null;
            DataSet dataset = new DataSet();
            DataTable table = new DataTable();

            cmd = conn.CreateCommand();

            cmd.CommandType = cmdType;
            cmd.CommandText = Commandtext;


            try
            {
                conn.Open();

                SqlDataAdapter da = null;
                using (da = new SqlDataAdapter(cmd))
                {
                    da.Fill(table);
                }
                dataset.Tables.Add(table);

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                cmd.Dispose();
                cmd = null;
                conn.Close();
            }
            return dataset;
        }
    }
}

