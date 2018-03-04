namespace eg.skrift.data.Models
{
    public partial class PrerecordedEvent: IEventDetail
    {
        public int EventRating
        {
            get => GetEventRating();
        }

        /// <summary>
        /// Gets the rating for an event.
        /// TODO: get average event rating for prerecorded event here
        /// </summary>
        /// <returns></returns>
        private int GetEventRating() => 3;
    }
}