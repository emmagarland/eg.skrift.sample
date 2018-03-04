namespace eg.skrift.data
{
    public partial class PrerecordedEvent : EventDetail
    {
        public override int EventRating => GetEventRating();

        /// <summary>
        /// Gets the rating for an event.
        /// TODO: get average event rating for prerecorded event here
        /// </summary>
        /// <returns></returns>
        private int GetEventRating() => 3;
    }
}