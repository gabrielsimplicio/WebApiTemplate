﻿using Swashbuckle.Application;
using System.Web.Http;

namespace WebApiTemplate
{
    public class SwaggerConfig
    {
        public static void Register(HttpConfiguration config)
        {
            config
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "WebApiTemplate");
                })
                .EnableSwaggerUi();
        }
    }
}