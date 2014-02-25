// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-21-2014
// ***********************************************************************
// <copyright file="OpenWeatherMapRequest.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Net.Http;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class OpenWeatherMapRequest.
    /// </summary>
    public class OpenWeatherMapRequest : IOpenWeatherMapRequest
    {
        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
        public Uri Uri { get; set; }

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>The application identifier.</value>
        public string AppId { get; set; }

        /// <summary>
        /// Gets or sets the querystring parameters.
        /// </summary>
        /// <value>The parameters.</value>
        public IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the HTTP client.
        /// </summary>
        /// <value>The HTTP client.</value>
        public HttpClient HttpClient { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        public HttpRequestMessage Request { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenWeatherMapRequest"/> class.
        /// </summary>
        /// <param name="uri">The URI.</param>
        /// <param name="httpClient">The HTTP client.</param>
        /// <param name="appId">The application identifier.</param>
        public OpenWeatherMapRequest(Uri uri, HttpClient httpClient, string appId)
        {
            Ensure.ArgumentNotNull(uri, "uri");
            Ensure.ArgumentNotNull(httpClient, "httpClient");

            Uri = uri;
            HttpClient = httpClient;
            Parameters = new Dictionary<string, string>();
            if (!string.IsNullOrEmpty(appId))
            {
                AppId = appId;
                Parameters.Add("APPID", appId);
            }
        }
    }
}
