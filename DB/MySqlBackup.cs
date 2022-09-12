using MySql.Data.MySqlClient;
using System;

namespace DB
{
    internal class MySqlBackup
    {
        private MySqlCommand cmd;

        public MySqlBackup(MySqlCommand cmd)
        {
            this.cmd = cmd;
        }

        internal void ExportToFile(string file)
        {
            throw new NotImplementedException();
        }

        internal void ImportFromFile(string file)
        {
            throw new NotImplementedException();
        }
    }
}