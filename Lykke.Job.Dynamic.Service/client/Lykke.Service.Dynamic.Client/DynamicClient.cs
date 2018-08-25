using System;
using Common.Log;
using JetBrains.Annotations;
using Lykke.Common.Log;

namespace Lykke.Service.Dynamic.Client
{
    [PublicAPI]
    public class DynamicClient : IDynamicClient, IDisposable
    {
        private readonly ILog _log;

        public DynamicClient(string serviceUrl, ILogFactory logFactory)
        {
            _log = logFactory.CreateLog(this);
        }

        public void Dispose()
        {
            //if (_service == null)
            //    return;
            //_service.Dispose();
            //_service = null;
        }
    }
}
