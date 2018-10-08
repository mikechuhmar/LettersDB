using MySql.Data.Entity;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersDBLibrary
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class LetterContext : DbContext
    {
        public virtual DbSet<Letter> Letters { get; set; }

        public LetterContext(DbConnection connection, bool contextOwnsConnection) : base(connection, contextOwnsConnection)
        {

        }
    }
}

