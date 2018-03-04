using Umbraco.Core.Models;

namespace eg.skrift.data.Models
{
    public class PrerecordedEventViewModel : EventDetail
    {
        public PrerecordedEventViewModel(IPublishedContent content) : base(content)
        {
        }

        public override int EventRating
        {
            get => GetEventRating();
            set { }
        }

        /// <summary>
        /// Gets the rating for an event.
        /// TODO: get average event rating for prerecorded event here
        /// </summary>
        /// <returns></returns>
        private int GetEventRating() => 3;
    }
}