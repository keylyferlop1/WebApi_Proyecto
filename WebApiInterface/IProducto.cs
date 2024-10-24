using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApiModels;
using WebApiServices;

namespace WebApiInterface
{
    internal interface IProducto
    {
        Task<IEnumerable<Productos>> GetProducto();
        Task<Productos> GetProductoAsync(int ID);
        Task createProductosAsync(Productos productos);
        Task updateProductosAsync(Productos productos);
        Task DeleteProductoAsysnc(Productos productos);
    }
}
