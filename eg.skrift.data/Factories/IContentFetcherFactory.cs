using eg.skrift.data.CMS;

namespace eg.skrift.data.Factories
{
    public interface IContentFetcherFactory
    {
        IUmbracoContentFetcher Create();
    }
}