using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IModels.Commons
{
    public interface IPerson
    {
        string Telephone { get; set; }
        string CPF { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        int Old { get; set; }
        int Id { get; set; }
    }
}
