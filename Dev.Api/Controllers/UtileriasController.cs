using Dev.Model.Response;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dev.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UtileriasController : ControllerBase
    {
        [HttpGet]
        [Route("Base64_Encode:string")]
        public ResponseModel<string> Base64_Encode(string str)
        {
            ResponseModel<string> response = new ResponseModel<string>();

            response = new ResponseModel<string>()
            { 
                Code = Enum.StatusCodeEnum.Ok,
                Message = str,
               
                Result = Dev.Util.Utileria.Base64_Encode(str)
            };

            return response;
        }

        [HttpGet]
        [Route("Base64_Decode:string")]
        public ResponseModel<string> Base64_Decode(string str)
        {
            ResponseModel<string> response = new ResponseModel<string>();

            response = new ResponseModel<string>()
            {
                Code = Enum.StatusCodeEnum.Ok,
                Message = str,

                Result = Dev.Util.Utileria.Base64_Decode(str)
            };

            return response;
        }


    }
}
