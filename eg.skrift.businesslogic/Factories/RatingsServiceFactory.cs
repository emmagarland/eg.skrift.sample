using eg.skrift.businesslogic.Services;

namespace eg.skrift.businesslogic.Factories
{
    public class RatingsServiceFactory : IRatingsServiceFactory
    {
        public RatingsServiceFactory(string connectionString)
        {
            //TODO: constructor
        }

        public IRatingsService Create()
        {
            return new RatingsService();
        }
    }
}