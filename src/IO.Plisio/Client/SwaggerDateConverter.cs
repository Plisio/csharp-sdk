/* 
 * Plisio API
 *
 * Plisio payment gateway API
 *
 * Contact: lead@plisio.net
 */
using Newtonsoft.Json.Converters;

namespace IO.Plisio.Client
{
    public class SwaggerDateConverter : IsoDateTimeConverter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SwaggerDateConverter" /> class.
        /// </summary>
        public SwaggerDateConverter()
        {
            // full-date   = date-fullyear "-" date-month "-" date-mday
            DateTimeFormat = "yyyy-MM-dd";
        }
    }
}
