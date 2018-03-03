using System;
using System.Globalization;
using Umbraco.Core.Models;

namespace eg.skrift.data
{
    public class EventDetail : Event
    {
        public EventDetail(IPublishedContent content) : base(content)
        {
        }

        /// <summary>
        /// Get the rating from Umbraco
        /// </summary>
        public int EventRating
        {
            get
            {
                try
                {
                    int.TryParse(Rating, out int rating);
                    return rating;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Issue when parsing the rating to an int", e);
                    throw;
                }
            }
        }
    }
}