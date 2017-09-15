using IModels.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IInfra
{
    public interface IPersonDataAccess
    {
        int Insert(IPerson person);
        bool Update(IPerson person);
        bool Delete(int id);
        IPerson Get(int id);
        IList<IPerson> Get();
        IList<IPerson> Get(int take, int skip);
    }
}
