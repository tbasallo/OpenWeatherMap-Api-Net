// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="ISearchClient.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Threading.Tasks;

namespace OpenWeatherMap
{
    /// <summary>
    /// Interface ISearchClient
    /// </summary>
    public interface ISearchClient
    {
        /// <summary>
        /// Search by city name.
        /// </summary>
        /// <param name="cityName">Name of the city.</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">The count.</param>
        /// <param name="accuracy">The accuracy.</param>
        /// <returns>Task{SearchResponse}.</returns>
        Task<SearchResponse> GetByName(
            string cityName,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN,
            int? count = null,
            Accuracy? accuracy = null
            );

        /// <summary>
        /// Search by coordinates.
        /// </summary>
        /// <param name="coordinates">The coordinates.</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">The count.</param>
        /// <param name="accuracy">The accuracy.</param>
        /// <returns>Task{SearchResponse}.</returns>
        Task<SearchResponse> GetByCoordinates(
            Coordinates coordinates,
            MetricSystem metric = MetricSystem.Internal,
            OpenWeatherMapLanguage language = OpenWeatherMapLanguage.EN,
            int? count = null,
            Accuracy? accuracy = null
            );
    }
}
