using eg.skrift.data.CMS;
using Umbraco.Web;

namespace eg.skrift.data.Factories
{
    /// <summary>
    /// Creates an UmbracoContentFetcher instance
    /// </summary>
    public class UmbracoContentFetcherFactory : IContentFetcherFactory
    {
        public IUmbracoContentFetcher Create()
        {
            return new UmbracoContentFetcher(new UmbracoHelper(UmbracoContext.Current));
        }
    }
}