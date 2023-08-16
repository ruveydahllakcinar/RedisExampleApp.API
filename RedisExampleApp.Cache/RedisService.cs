using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Text;

namespace RedisExampleApp.Cache
{
    public class RedisService
    {
        private readonly ConnectionMultiplexer _multiplexer;

        public RedisService(string url)
        {
            _multiplexer = ConnectionMultiplexer.Connect(url);
        }


        public IDatabase GetDb(int dbIndex)
        {
            return _multiplexer.GetDatabase(dbIndex);
        }
    }
}
