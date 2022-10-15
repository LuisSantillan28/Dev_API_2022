using System;
using System.Collections.Generic;
using System.Text;

namespace Dev.Model
{
    public static class varDirectory
    {
        public static readonly string dbConnection;
        static varDirectory()
        {
            switch(Environment.GetEnvironmentVariable("ASPNETCORE_ENVIROMENT"))
            {
                case "Development":
                    dbConnection = "Server=localhost;Port=3307;Database=bd_ventas; Uid=root;Pwd=1234";
                    break;
                default:
                    dbConnection = "Server=localhost;Port=3307;Database=bd_ventas; Uid=root;Pwd=1234";
                    break;
            }
        }

    }
}
