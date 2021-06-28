using System;

namespace FactoryPattern2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What database would you like to use: List, SQL, or Mongo?");

            var input = Console.ReadLine();

            var accessType = DataAccessFactory.GetDataAccessType(input);

            accessType.LoadData();
            accessType.SaveData();
        }
    }
}
