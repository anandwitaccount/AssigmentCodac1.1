using AssigmentCodac;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using static AssigmentCodac.IserviceClass;

namespace MarsRoverAssigmentCodac
{
    public class Program
    {
       
        static void Main(string[] args)
        {
            var serviceProvider = Config.configmethod();
            var service = serviceProvider.GetService<IService>();
            service.GetPositionResult();
        }
    }
}
