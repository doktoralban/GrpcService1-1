using Grpc.Core;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcService1
{
    public class HesaplaService
    {
        private readonly ILogger<HesaplaService> _logger;
        public HesaplaService(ILogger<HesaplaService> logger)
        {
            _logger = logger;
        }







    }
}
