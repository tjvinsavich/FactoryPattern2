using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern2
{
    public interface IDataAccess
    {
        public List<Product> LoadData();
        public void SaveData();
    }
}
