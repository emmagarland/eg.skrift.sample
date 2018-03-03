﻿using System.Web.Mvc;
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
            typedModel.EventRating = GetEventRating();
            return CurrentTemplate(typedModel);
        }

        /// <summary>
        /// Gets the rating for an event
        /// </summary>
        /// <returns></returns>
        private int GetEventRating()
        {
            //TODO: get rating from ratings service
            return 4;
        }
    }
}