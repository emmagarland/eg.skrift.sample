namespace eg.skrift.data
{
    public partial class InterviewEvent : EventDetail
    {
        public override int EventRating => GetEventRating();

        /// <summary>
        /// Gets the rating for an event.
        /// TODO: get average event rating for interview event here
        /// </summary>
        /// <returns></returns>
        private int GetEventRating() => 4;
    }
}