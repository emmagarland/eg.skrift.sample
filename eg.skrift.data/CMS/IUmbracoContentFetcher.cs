using Umbraco.Core.Models;

namespace eg.skrift.data.CMS
{
    public interface IUmbracoContentFetcher
    {
        IPublishedContent TypedContent(int id);
    }
}