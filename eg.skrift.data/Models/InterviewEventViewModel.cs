using Umbraco.Core.Models;

namespace eg.skrift.data.Models
{
    public class InterviewEventViewModel : EventDetail
    {
        public InterviewEventViewModel(IPublishedContent content) : base(content)
        {
        }

        public override int EventRating
        {
            get => GetEventRating();
            set { }
        }

        /// <summary>
        /// Gets the rating for an event.
        /// TODO: get average event rating for interview event here
        /// </summary>
        /// <returns></returns>
        private int GetEventRating() => 4;

    }
}