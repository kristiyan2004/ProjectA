using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectA
{
    public interface IDescription
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        char Gender { get; set; }
        void Introduce();
    }
}
