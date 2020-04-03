using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainModels.Abstraction
{
    public interface IUser
    {
        string Name { get; set; }
        string Surname { get; set; }
        string Image { get; set; }
        int Age { get; set; }
        string Email { get; set; }
    }
}
