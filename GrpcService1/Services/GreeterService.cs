using Grpc.Core;
using GrpcService1.Data;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GrpcService1.Controllers;
using GrpcService1.Models;

namespace GrpcService1
{
    public class GreeterService : Greeter.GreeterBase
    {
        private readonly ILogger<GreeterService> _logger;
        public GreeterService(ILogger<GreeterService> logger)
        {
            _logger = logger;
        }

        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context )
        {
            UserController uc = new UserController(new NorthwindEntities()  );

            //var k = uc.isUserOk("abc", "xyz");

            return Task.FromResult(new HelloReply
            {
                Message = "Hello ************* " + request.Name + " - " + request.Xyz
            }); ;
        }




    }
}
