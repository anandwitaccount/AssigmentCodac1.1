using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AssigmentCodac.IserviceClass;

namespace AssigmentCodac
{
    public class Config
    {
        public static ServiceProvider configmethod()
        {
            //setup our DI
            ServiceProvider service = new ServiceCollection()
             .AddSingleton<IRepoPosition, RepoPositionClass>()
             .AddSingleton<IService, Services>()
             .BuildServiceProvider();

            return service;

        }
    }
}
