using SocialovateDomainDTOs;
using SocialovateDomainModels.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialovateDomainServices.Abstraction
{
    public interface IContactService
    {
        Action<IAccount> CreateContactDel { get; set; }
        Func<LoginDTO, IAccount> ReadContactDel { get; set; }
        Action<IAccount> UpdateContactDel { get; set; }
        Action<IAccount> DeleteContactDel { get; set; }

        Func<List<IAccount>, ContactDTO> FilterContactsByName {get;set;}

    }
}
