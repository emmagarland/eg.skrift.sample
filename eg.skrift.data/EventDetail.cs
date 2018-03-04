using System;
using Umbraco.Core.Models;

namespace eg.skrift.data
{
    public class EventDetail : Event, IEventRating
    {
        public EventDetail(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Get the rating from Umbraco
        /// </summary>
        public int EventRating { get; set; }
    }
}