using IInfra;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IModels.Commons;
using Models.Commons;
using System.Data.SqlClient;

namespace Infra
{
    public class PersonDataAccess : IPersonDataAccess
    {
        private SqlConnection _connection;
        public PersonDataAccess()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=webtestproject;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            _connection = new SqlConnection(connectionString);
            _connection.Open();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IList<IPerson> Get()
        {
            throw new NotImplementedException();
        }

        public IPerson Get(int id)
        {
            return new Person()
            {
                CPF = "06454.444.45455",
                Name = "Jeferson ",
                Surname = "dos Anjos",
                Old= 33,
                Telephone = "(31)1111-1111"
            };
            //throw new NotImplementedException();
        }

        public IList<IPerson> Get(int take, int skip)
        {
            throw new NotImplementedException();
        }

        public int Insert(IPerson person)
        {
            throw new NotImplementedException();
        }

        public bool Update(IPerson person)
        {
            throw new NotImplementedException();
        }
    }
}
