﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace KipWeb5
{
    static class ConfigurationHelper
    {
        public static IConfiguration ResolveConfiguration(IWebHostEnvironment environment)
        {
            var reportingConfigFileName = System.IO.Path.Combine(environment.ContentRootPath, "appsettings.json");
            return new ConfigurationBuilder()
                .AddJsonFile(reportingConfigFileName, true)
                .Build();
        }
    }
}