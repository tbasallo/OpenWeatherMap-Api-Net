// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="ForecastClient.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading.Tasks;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class ForecastClient.
    /// </summary>
    public class ForecastClient : ApiClientBase, IForecastClient
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForecastClient"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        public ForecastClient(IOpenWeatherMapRequest request)
            : base(request, "forecast")
        {
            Request = request;
            Request.Uri.AddSegment("forecast");
        }

        /// <summary>
        /// Gets Forecast by city name.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        /// <param name="daily">if set to <c>true</c> [daily].</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">Number of results.</param>
        /// <returns>Task{ForecastResponse}.</returns>
        public Task<ForecastResponse> GetByName(
            string cityName,
            bool daily = false,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN,
            int? count = null
            )
        {
            if (daily) Request.Uri = Request.Uri.AddSegment("daily");
            return base.GetByName<ForecastResponse>(cityName, metric, language, count, null);
        }

        /// <summary>
        /// Gets Forecast by coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <param name="daily">if set to <c>true</c> [daily].</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">The count.</param>
        /// <returns>Task{ForecastResponse}.</returns>
        public Task<ForecastResponse> GetByCoordinates(
            Coordinates coordinates,
            bool daily = false,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN,
            int? count = null
            )
        {
            if (daily) Request.Uri = Request.Uri.AddSegment("daily");
            return base.GetByCoordinates<ForecastResponse>(coordinates, metric, language, count, null);
        }

        /// <summary>
        /// Gets Forecast by city identifier.
        /// </summary>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="daily">if set to <c>true</c> [daily].</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">The count.</param>
        /// <returns>Task{ForecastResponse}.</returns>
        public Task<ForecastResponse> GetByCityId(
            int cityId,
            bool daily = false,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN,
            int? count = null
            )
        {
            if (daily) Request.Uri = Request.Uri.AddSegment("daily");
            return base.GetByCityId<ForecastResponse>(cityId, metric, language, count);
        }
    }
}
