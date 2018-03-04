using Umbraco.Core.Models;

namespace eg.skrift.data.Models
{
    public abstract class EventDetail : EventBase, IEventRating
    {
        protected EventDetail(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Get the rating from Umbraco
        /// </summary>
        public abstract int EventRating { get; set; }
    }
}