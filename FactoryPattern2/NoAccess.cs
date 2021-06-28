using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public class NoAccess : IDataAccess
    {
        public NoAccess()
        {
            Console.WriteLine("Invalid database.");
        }

        public List<Product> LoadData()
        {
            return new List<Product>();
        }

        public void SaveData()
        {
        }
    }
}
