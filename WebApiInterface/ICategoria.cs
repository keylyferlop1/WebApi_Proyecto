using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModels;

namespace WebApiInterface
{
    public interface ICategoria
    {
        Task<IEnumerable<Categoria>> GetCategoria();
        Task<Categoria> GetCategoriaAsync(int ID);
        Task createCategoriaAsync(Categoria categoria);
        Task updateCategoriaAsync(Categoria categoria);
        Task DeleteCategoriaAsysnc(Categoria categoria);
    }
}
