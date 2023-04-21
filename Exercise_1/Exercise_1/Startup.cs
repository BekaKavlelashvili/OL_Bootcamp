using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    public class StartUp
    {
        public StartUp()
        {
             var builder = new ConfigurationBuilder().
                SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            IConfiguration config = builder.Build();

            Settings = config.GetSection("UserSettings").Get<Settings>();
        }

        public Settings Settings { get; private set; }
    }
}
