using Dapper;
using Dev.Data.Repository;
using Dev.Model.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Dev.Business.Procucto
{
    public class ProductoBusiness
    {
        GeneralRepository<object> repository;
        public ProductoBusiness()
        {
            repository = new GeneralRepository<object>();   
        }

        public ResponseModel<object> getProductos()
        {
            ResponseModel<object> response = new ResponseModel<object>();

            try
            {
                response.Result = repository.GetList("sps_productos");
                response.Code = Enum.StatusCodeEnum.Ok;
                response.Message = "";

            }
            catch (Exception e)
            {
                response.Message = $"Algo salió mal Error => {e.Message}";
                response.Code = Enum.StatusCodeEnum.Bad_Request;
            }
            return response;
        }

        public ResponseModel<object> getProductoById(int id)
        {
            ResponseModel<object> response = new ResponseModel<object>();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("param", id, DbType.Int32);//renombrar parametro


                response.Result = repository.GetSingle("sps_producto", parameters);//renombrar store
                response.Code = Enum.StatusCodeEnum.Ok;
                response.Message = "";
            }
            catch (Exception e)
            {
                response.Result = -1;
                response.Code = Enum.StatusCodeEnum.Bad_Request;
                response.Message = e.Message;
            }
            return response;
        }
        public ResponseModel<int> InsertProducto(string nombre, double precio, int cantidad)
        {
            ResponseModel<int> response = new ResponseModel<int>();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("p_nombre", nombre, DbType.String);
                parameters.Add("p_precio", precio, DbType.Double);
                parameters.Add("p_stock", cantidad, DbType.Int32);


                response.Result = repository.Execute("spi_producto", parameters, true);
                response.Code = Enum.StatusCodeEnum.Ok;
                response.Message = "";
            }
            catch (Exception e)
            {
                response.Result = -1;
                response.Code = Enum.StatusCodeEnum.Bad_Request;
                response.Message = e.Message;
            }
            return response;
        }

        public ResponseModel<int> UpdateProducto(int id,string nombre, double precio, int cantidad)
        {
            ResponseModel<int> response = new ResponseModel<int>();
            try
            {
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("product", id, DbType.Int32);
                parameters.Add("pname", nombre, DbType.String);
                parameters.Add("price", precio, DbType.Double);
                parameters.Add("stock", cantidad, DbType.Int32);


                response.Result = repository.Execute("spu_productos", parameters, true);
                response.Code = Enum.StatusCodeEnum.Ok;
                response.Message = "";
            }
            catch (Exception e)
            {
                response.Result = -1;
                response.Code = Enum.StatusCodeEnum.Bad_Request;
                response.Message = e.Message;
            }
            return response;
        }

    }
}
