using Umbraco.Core.Models;
using Umbraco.Web;

namespace eg.skrift.data.CMS
{
    /// <summary>
    /// Wraps the Umbraco helper and handles content-related functionality
    /// </summary>
    public class UmbracoContentFetcher : IUmbracoContentFetcher
    {
        private readonly UmbracoHelper umbracoHelper;

        public UmbracoContentFetcher(UmbracoHelper umbracoHelper)
        {
            this.umbracoHelper = umbracoHelper;
        }

        /// <summary>
        /// Return typed content by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IPublishedContent TypedContent(int id)
        {
            return umbracoHelper.TypedContent(id);
        }
    }
}