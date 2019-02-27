namespace MediaBrowser.Model.Services
{
    public interface IHttpRequest : IRequest
    {
        /// <summary>
        /// The HTTP Verb
        /// </summary>
        string HttpMethod { get; }

        /// <summary>
        /// The IP Address of the X-Forwarded-For header, null if null or empty
        /// </summary>
        string XForwardedFor { get; }

        /// <summary>
        /// The Port number of the X-Forwarded-Port header, null if null or empty
        /// </summary>
        int? XForwardedPort { get; }

        /// <summary>
        /// The http or https scheme of the X-Forwarded-Proto header, null if null or empty
        /// </summary>
        string XForwardedProtocol { get; }

        /// <summary>
        /// The value of the X-Real-IP header, null if null or empty
        /// </summary>
        string XRealIp { get; }

        /// <summary>
        /// The value of the Accept HTTP Request Header
        /// </summary>
        string Accept { get; }
    }
}
