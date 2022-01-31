using System;

namespace ClassLibrary1
{
    public class BierRepository
    {
        //giving the connectiong sting:
        private readonly string _connectionString;
        public BierRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

    }
}
