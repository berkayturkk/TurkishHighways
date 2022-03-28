using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurkıshHighways.Helper.Abstract
{
    public interface IDbContext
    {
        DataTable ExecuteQuery(string sql, CommandType commandType, params SqlParameter[] parameters);
        int ExecuteNonQuery(string sql, CommandType commandType, params SqlParameter[] parameters);
    }
}
