using Dev.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Model.Response
{
    public class ResponseModel<T>
    {
        //List<Object> objects;
        public StatusCodeEnum Code {get; set;}

        public string Message {get; set;}
        public T Result {get; set;}

    }
}
