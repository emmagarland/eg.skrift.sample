namespace eg.skrift.businesslogic.Services
{
    public interface IStoreRatings
    {
        /// <summary>
        /// Store a rating for a given event
        /// </summary>
        /// <param name="rating"></param>
        /// <param name="eventID"></param>
        void SetRating(int rating, int eventID);
    }
}