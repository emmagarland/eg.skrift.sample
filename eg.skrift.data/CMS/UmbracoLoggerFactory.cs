using System;

namespace eg.skrift.data.CMS
{
    public class UmbracoLoggerFactory : ILoggerFactory
    {
        public ILogger Create(Type source)
        {
            return new UmbracoLogger(source);
        }
    }
}