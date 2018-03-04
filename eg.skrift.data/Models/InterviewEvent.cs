namespace eg.skrift.data.Models
{
    public partial class InterviewEvent : IEventDetail
    {
        public int EventRating => GetEventRating();

        /// <summary>
        /// Gets the rating for an event.
        /// TODO: get average event rating for interview event here
        /// </summary>
        /// <returns></returns>
        private int GetEventRating() => 4;
    }
}