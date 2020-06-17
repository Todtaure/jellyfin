using MediaBrowser.Common.Json;
using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

namespace Jellyfin.Server.Formatters
{
    /// <summary>
    /// Camel Case Json Profile Formatter.
    /// </summary>
    public class CamelCaseJsonProfileFormatter : SystemTextJsonOutputFormatter
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CamelCaseJsonProfileFormatter"/> class.
        /// </summary>
        public CamelCaseJsonProfileFormatter() : base(JsonDefaults.GetCamelCaseOptions())
        {
            SupportedMediaTypes.Clear();
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("application/json;profile=\"CamelCase\""));
        }
    }
}