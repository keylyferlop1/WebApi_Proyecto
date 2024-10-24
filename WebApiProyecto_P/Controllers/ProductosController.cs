using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiModels;
using WebApiInterface;

namespace WebApiProyecto_P.Controllers
{
    [Route("Api/[Controllers]")]
    [ApiController]
    public class ProductosController : ControllerBase
    {
        private readonly IProductoServices _ProductosServices;

        public ProductosController(IProductoServices productosServices)
        {
            _ProductosServices = productosServices;
        }
    }
    //Get: Api / Producto
}
