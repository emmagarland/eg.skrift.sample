using Umbraco.Core.Models;

namespace eg.skrift.data
{
    public class EventDetail : Event
    {
        public EventDetail(IPublishedContent content) : base(content)
        {
        }

        public int EventRating { get; set; }
    }
}