using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//...
using System.Data.OleDb;//...

namespace businessCard
{
   public interface IDataBase
    {
        //İmza
        void add(Kisiler kişiler);

        void Update(Kisiler kişiler);

        DataTable Refresh(OleDbDataAdapter adtr, string sorgu);

    }
}
