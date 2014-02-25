// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="CurrentWeatherClient.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading.Tasks;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class CurrentWeatherClient.
    /// </summary>
    public class CurrentWeatherClient : ApiClientBase, ICurrentWeatherClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CurrentWeatherClient"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        public CurrentWeatherClient(IOpenWeatherMapRequest request)
            : base(request, "weather")
        {
        }

        /// <summary>
        /// Gets Current weather by city name.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        /// <param name="metric">The metric system.</param>
        /// <param name="language">The language.</param>
        /// <returns>Task{CurrentWeatherResponse}.</returns>
        public Task<CurrentWeatherResponse> GetByName(
            string cityName,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN
            )
        {
            return base.GetByName<CurrentWeatherResponse>(cityName, metric, language, null, null);
        }

        /// <summary>
        /// Gets Current weather by coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <param name="metric">The metric system.</param>
        /// <param name="language">The language.</param>
        /// <returns>Task{CurrentWeatherResponse}.</returns>
        public Task<CurrentWeatherResponse> GetByCoordinates(
            Coordinates coordinates,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN
            )
        {
            return base.GetByCoordinates<CurrentWeatherResponse>(coordinates, metric, language, null, null);
        }

        /// <summary>
        /// Gets Current weather by city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <returns>Task{CurrentWeatherResponse}.</returns>
        public Task<CurrentWeatherResponse> GetByCityId(
            int cityId,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN
            )
        {
            return base.GetByCityId<CurrentWeatherResponse>(cityId, metric, language, null);
        }
    }
}
