using eg.skrift.businesslogic.Factories;

namespace eg.skrift.businesslogic.Services
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