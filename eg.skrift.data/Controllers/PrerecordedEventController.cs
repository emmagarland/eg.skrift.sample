using eg.skrift.businesslogic.Factories;
using eg.skrift.data.CMS;

namespace eg.skrift.data.Controllers
{
    public class PrerecordedEventController : EventBaseController
    {
        public PrerecordedEventController(ILoggerFactory loggerFactory, IRatingsServiceFactory ratingsServiceFactory) : base(loggerFactory, ratingsServiceFactory)
        {
        }
    }
}