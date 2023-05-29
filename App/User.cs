using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace test2_sql_f
{
    public class Users
    {
        [PrimaryKey,AutoIncrement] 
        public int Id { get; set; }
        public int Number { get; set; }
        public int Code { get; set; }


    }
}
