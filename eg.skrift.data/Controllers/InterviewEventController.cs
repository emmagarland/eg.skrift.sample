using eg.skrift.businesslogic.Factories;
using eg.skrift.data.CMS;

namespace eg.skrift.data.Controllers
{
    public class InterviewEventController : EventBaseController
    {
        public InterviewEventController()
        {
        }

        public InterviewEventController(ILoggerFactory loggerFactory, IRatingsServiceFactory ratingsServiceFactory) : base(loggerFactory, ratingsServiceFactory)
        {
        }
    }
}