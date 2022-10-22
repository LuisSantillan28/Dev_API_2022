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
        [HttpGet]
        public ResponseModel<object> getProductoById(int id)
        {
            return producto.getProductoById(id);
        }
        #region Post
        [HttpPost]
        public ResponseModel<int> InsertaProducto(string nombre, double precio, int cantidad)
        {
            return producto.InsertProducto(nombre, precio, cantidad);
        }
        #endregion

        #region Post
        [HttpPost]
        public ResponseModel<int> UpdateProducto(int id, string nombre, double precio, int cantidad)
        {
            return producto.UpdateProducto(id, nombre, precio, cantidad);
        }
        #endregion


    }
}
