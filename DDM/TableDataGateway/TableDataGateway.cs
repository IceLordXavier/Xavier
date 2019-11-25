using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DDM.TableDataGateway
{
    public abstract class TableDataGateway<T>
    {
        public static DataTable Find(SqlConnection connection) { throw new  NotImplementedException();  }
    }
}
