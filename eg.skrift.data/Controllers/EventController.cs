using System.Web.Mvc;
using Our.Umbraco.Ditto;
using Umbraco.Web.Models;
using Umbraco.Web.Mvc;

namespace eg.skrift.data.Controllers
{
    public class EventController : RenderMvcController
    {
        /// <summary>
        /// Renders the Event page
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public override ActionResult Index(RenderModel model)
        {
            var typedModel = model.As<EventDetail>();
            return CurrentTemplate(typedModel);
        }

        /// <summary>
        /// Legacy: Gets the rating for an event
        /// Used in earlier code example
        /// </summary>
        /// <returns></returns>
        private int GetEventRating()
        {
            //TODO: get rating from ratings service
            return 4;
        }
    }
}