﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TT.BaseProject.Domain.Business;
using TT.BaseProject.Domain.Config;
using TT.BaseProject.Domain.Context;

namespace TT.BaseProject.Domain.MySql.Business
{
    public class MySqlExampleRepo : MySqlBusinessRepo, IExampleRepo
    {
        protected readonly IContextService _contextService;
        protected readonly IOptions<ConnectionConfig> _config;

        public MySqlExampleRepo(IOptions<ConnectionConfig> config, IServiceProvider serviceProvider) : base(null, serviceProvider)
        {
            _config = config;
            _contextService = serviceProvider.GetRequiredService<IContextService>();
        }
    }
}
