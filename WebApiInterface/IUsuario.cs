using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModels;

namespace WebApiInterface
{
    public interface IUsuario
    {
        Task<IEnumerable<Usuarios>> GetUsuario();

        Task<Usuarios> GetUsuarioAsync(int ID);

        Task createUsuarioAsync(Usuarios usuarios);

        Task updateUsuarioAsync(Usuarios usuarios);

        Task DeleteUsuarioAsysnc(Usuarios usuarios);
    }
}
