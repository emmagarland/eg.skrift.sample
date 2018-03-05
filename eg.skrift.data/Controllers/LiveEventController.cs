using eg.skrift.businesslogic.Factories;
using eg.skrift.data.CMS;

namespace eg.skrift.data.Controllers
{
    public class LiveEventController : EventBaseController
    {
        public LiveEventController(ILoggerFactory loggerFactory, IRatingsServiceFactory ratingsServiceFactory) : base(loggerFactory, ratingsServiceFactory)
        {
        }
    }
}