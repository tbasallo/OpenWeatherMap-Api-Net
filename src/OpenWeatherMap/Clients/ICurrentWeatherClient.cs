// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-19-2014
// ***********************************************************************
// <copyright file="ICurrentWeatherClient.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading.Tasks;

namespace OpenWeatherMap
{
    /// <summary>
    /// Interface ICurrentWeatherClient
    /// </summary>
    public interface ICurrentWeatherClient
    {
        /// <summary>
        /// Gets Current weather by city name.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        /// <param name="metric">The metric system.</param>
        /// <param name="language">The language.</param>
        /// <returns>Task{CurrentWeatherResponse}.</returns>
        Task<CurrentWeatherResponse> GetByName(
            string cityName,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN
            );

        /// <summary>
        /// Gets Current weather by coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <param name="metric">The metric system.</param>
        /// <param name="language">The language.</param>
        /// <returns>Task{CurrentWeatherResponse}.</returns>
        Task<CurrentWeatherResponse> GetByCoordinates(
            Coordinates coordinates,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN
            );

        /// <summary>
        /// Gets Current weather by city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <returns>Task{CurrentWeatherResponse}.</returns>
        Task<CurrentWeatherResponse> GetByCityId(
            int cityId,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN
            );
    }
}
