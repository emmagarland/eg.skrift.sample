namespace eg.skrift.businesslogic.Services
{
    /// <summary>
    /// Service to get and set ratings for an event
    /// </summary>
    public class RatingsService : IRatingsService
    {
        /// <summary>
        /// Get an event rating
        /// </summary>
        /// <param name="eventId"></param>
        /// <returns></returns>
        public int GetRating(int eventId)
        {
            //TODO: implement functionality
            return 5;
        }

        /// <summary>
        /// Set an event rating
        /// </summary>
        /// <param name="rating"></param>
        /// <param name="eventID"></param>
        public void SetRating(int rating, int eventID)
        {
            //TODO: implement functionality                        
        }
    }
}