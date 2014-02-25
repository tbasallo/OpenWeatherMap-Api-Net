// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="IOpenWeatherMapRequest.cs" company="Joan Caron">
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
    /// Interface IOpenWeatherMapRequest
    /// </summary>
    public interface IOpenWeatherMapRequest
    {
        /// <summary>
        /// Gets or sets the URI.
        /// </summary>
        /// <value>The URI.</value>
        Uri Uri { get; set; }

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>The application identifier.</value>
        string AppId { get; set; }

        /// <summary>
        /// Gets or sets the querystring parameters.
        /// </summary>
        /// <value>The parameters.</value>
        IDictionary<string, string> Parameters { get; set; }

        /// <summary>
        /// Gets or sets the HTTP client.
        /// </summary>
        /// <value>The HTTP client.</value>
        HttpClient HttpClient { get; set; }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        HttpRequestMessage Request { get; set; }
    }
}
