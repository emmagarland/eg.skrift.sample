using System;

namespace eg.skrift.data.CMS
{
    public interface ILoggerFactory
    {
        ILogger Create(Type source);
    }
}