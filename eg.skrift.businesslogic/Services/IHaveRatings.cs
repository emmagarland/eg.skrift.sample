namespace eg.skrift.businesslogic.Services
{
    public interface IHaveRatings
    {
        /// <summary>
        /// Get a rating for a given event
        /// </summary>
        /// <param name="eventId"></param>
        int GetRating(int eventId);
    }
}