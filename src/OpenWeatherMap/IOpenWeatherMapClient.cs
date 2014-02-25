// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-22-2014
// ***********************************************************************
// <copyright file="IOpenWeatherMapClient.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OpenWeatherMap
{
    /// <summary>
    /// Interface IOpenWeatherMapClient
    /// </summary>
    public interface IOpenWeatherMapClient
    {
        /// <summary>
        /// Gets or sets the application identifier.
        /// </summary>
        /// <value>The application identifier.</value>
        string AppId { get; set; }

        /// <summary>
        /// Gets the current weather client.
        /// </summary>
        /// <value>The current weather.</value>
        ICurrentWeatherClient CurrentWeather { get; }

        /// <summary>
        /// Gets the forecast client.
        /// </summary>
        /// <value>The forecast.</value>
        IForecastClient Forecast { get; }

        /// <summary>
        /// Gets the search client.
        /// </summary>
        /// <value>The search.</value>
        ISearchClient Search { get; }
    }
}
