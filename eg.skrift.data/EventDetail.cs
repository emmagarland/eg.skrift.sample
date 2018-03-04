using Umbraco.Core.Models;

namespace eg.skrift.data
{
    public abstract class EventDetail : EventBase, IEventRating
    {
        protected EventDetail(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Get the rating from Umbraco
        /// </summary>
        public abstract int EventRating { get; }
    }
}