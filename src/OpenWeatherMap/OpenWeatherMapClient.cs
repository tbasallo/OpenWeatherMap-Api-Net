// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-22-2014
// ***********************************************************************
// <copyright file="OpenWeatherMapClient.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Net.Http;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class OpenWeatherMapClient.
    /// </summary>
    public class OpenWeatherMapClient : IOpenWeatherMapClient
    {
        /// <summary>
        /// The open weather map URL
        /// </summary>
        public static readonly Uri OpenWeatherMapUrl = new Uri("http://api.openweathermap.org/data/2.5");

        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>The application identifier.</value>
        public string AppId { get; set; }

        /// <summary>
        /// Gets the current weather client.
        /// </summary>
        /// <value>The current weather.</value>
        public ICurrentWeatherClient CurrentWeather
        {
            get { return new CurrentWeatherClient(new OpenWeatherMapRequest(OpenWeatherMapUrl, HttpClient, AppId)); }
        }

        /// <summary>
        /// Gets the forecast client.
        /// </summary>
        /// <value>The forecast.</value>
        public IForecastClient Forecast
        {
            get { return new ForecastClient(new OpenWeatherMapRequest(OpenWeatherMapUrl, HttpClient, AppId)); }
        }

        /// <summary>
        /// Gets the search client.
        /// </summary>
        /// <value>The search.</value>
        public ISearchClient Search
        {
            get { return new SearchClient(new OpenWeatherMapRequest(OpenWeatherMapUrl, HttpClient, AppId)); }
        }

        /// <summary>
        /// Gets or sets the HTTP client.
        /// </summary>
        /// <value>The HTTP client.</value>
        HttpClient HttpClient { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenWeatherMapClient"/> class.
        /// </summary>
        /// <param name="appId">The application identifier.</param>
        /// <param name="httpMessageHandler">The HTTP message handler.</param>
        public OpenWeatherMapClient(string appId = null, HttpMessageHandler httpMessageHandler = null)
        {
            if (httpMessageHandler == null)
            {
                httpMessageHandler = new HttpClientHandler();
            }
            HttpClient = new HttpClient(httpMessageHandler);
            AppId = appId;
        }
    }
}
