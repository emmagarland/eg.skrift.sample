﻿using Umbraco.Core.Models;

namespace eg.skrift.data.Models
{
    public class EventDetail : EventBase, IEventDetail
    {
        protected EventDetail(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Get the rating from Umbraco
        /// </summary>
        public int EventRating { get; set; }
    }
}