using Dev.Business.Procucto;
using Dev.Model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dev.Api.Controllers.Producto
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductoController : ControllerBase
    {
        ProductoBusiness producto;

        public ProductoController()
        {
            producto = new ProductoBusiness();
        }
        [HttpGet]
        public ResponseModel<object> getProductos()
        {
            return producto.getProductos();
        }

    }
}
