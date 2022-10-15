using Dev.Data.Repository;
using Dev.Model.Response;
using System;
using System.Collections.Generic;
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

            }catch (Exception e)
            {
                response.Message= $"Algo salió mal Error => {e.Message}";
                response.Code = Enum.StatusCodeEnum.Bad_Request;
            }
            return response;
        }
    }
}
