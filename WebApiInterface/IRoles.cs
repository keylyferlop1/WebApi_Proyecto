using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModels;

namespace WebApiInterface
{
    public interface IRoles
    {
        Task<IEnumerable<Roles>> GetRoles();

        Task<Roles> GetRolesAsync(int ID);

        Task createRolesAsync(Roles roles);

        Task updateRolesAsync(Roles roles);

        Task DeleteRolesAsysnc(Roles roles);
    }
}
