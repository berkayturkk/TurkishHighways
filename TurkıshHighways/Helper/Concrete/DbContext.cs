using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurkıshHighways.Helper.Abstract;

namespace TurkıshHighways
{
    public class DbContext:IDbContext
    {
        private SqlConnection _conn;
        private SqlCommand _cmd;
        private DataTable _tbl;
        public DbContext(string str = null)
        {
            if (str == null)
            {
                _conn = new SqlConnection(Parametreler.constr);
            }              
            else
            {
                _conn = new SqlConnection(str);
            }                    

            _cmd = new SqlCommand();
            _cmd.Connection = _conn;
        }
        public int ExecuteNonQuery(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            switch (commandType)
            {
                case CommandType.Text:
                    _cmd.CommandType = CommandType.Text;
                    break;

                case CommandType.StoredProcedure:
                    {
                        _cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            _cmd.Parameters.AddRange(parameters);
                        }
                    }
                    break;

                default:
                    break;
            }
            return _cmd.ExecuteNonQuery();
        }

        public DataTable ExecuteQuery(string sql, CommandType commandType, params SqlParameter[] parameters)
        {
            switch (commandType)
            {
                case CommandType.Text:
                    _cmd.CommandType = CommandType.Text;
                    break;

                case CommandType.StoredProcedure:
                    {
                        _cmd.CommandText = sql;
                        _cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                        {
                            _cmd.Parameters.AddRange(parameters);
                        }
                    }
                    break;

                default:
                    break;
            }
            _conn.Open();
            _tbl = new DataTable();
            _tbl.Load(_cmd.ExecuteReader());
            _conn.Close();
            return _tbl;
        }
    }
}
