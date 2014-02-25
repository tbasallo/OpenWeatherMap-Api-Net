// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-21-2014
// ***********************************************************************
// <copyright file="ApiClientBase.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Globalization;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class ApiClientBase.
    /// </summary>
    public class ApiClientBase : IApiClientBase
    {
        /// <summary>
        /// Gets or sets the openweathermap request.
        /// </summary>
        /// <value>The request.</value>
        public IOpenWeatherMapRequest Request { get; set; }

        /// <summary>
        /// Gets by name.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cityName">Name of the city.</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">The count.</param>
        /// <param name="accuracy">The accuracy.</param>
        /// <returns>Task{``0}.</returns>
        internal Task<T> GetByName<T>(
            string cityName,
            MetricSystem metric,
            OpenWeatherMapLanguage language,
            int? count,
            Accuracy? accuracy
            )
        {
            Ensure.ArgumentNotNullOrEmptyString(cityName, "cityName");
            Ensure.ArgumentNotNull(metric, "metric");
            Ensure.ArgumentNotNull(language, "language");

            Request.Parameters.Add("q", cityName.UrlEncode());
            if (metric != MetricSystem.Internal)
                Request.Parameters.Add("units", metric.ToString().ToLowerInvariant());
            if (language != OpenWeatherMapLanguage.EN)
                Request.Parameters.Add("lang", language.ToString().ToLowerInvariant());

            if (count.HasValue)
            {
                Request.Parameters.Add("cnt", count.Value.ToString(CultureInfo.InvariantCulture));
            }
            if (accuracy.HasValue)
            {
                Request.Parameters.Add("type", accuracy.Value.ToString().ToLowerInvariant());
            }

            return RunGetRequest<T>();
        }

        /// <summary>
        /// Gets by coordinates.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="coordinates">The coordinates.</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">The count.</param>
        /// <param name="accuracy">The accuracy.</param>
        /// <returns>Task{``0}.</returns>
        internal Task<T> GetByCoordinates<T>(Coordinates coordinates,
            MetricSystem metric,
            OpenWeatherMapLanguage language,
            int? count,
            Accuracy? accuracy)
        {
            Ensure.ArgumentNotNull(metric, "metric");
            Ensure.ArgumentNotNull(language, "language");
            Ensure.ArgumentNotNull(coordinates, "coordinates");
            Ensure.ArgumentNotNull(coordinates.Latitude, "coordinates.Latitude");
            Ensure.ArgumentNotNull(coordinates.Longitude, "coordinates.Longitude");

            Request.Parameters.Add("lat", coordinates.Latitude.ToString(CultureInfo.InvariantCulture));
            Request.Parameters.Add("lon", coordinates.Longitude.ToString(CultureInfo.InvariantCulture));

            if (metric != MetricSystem.Internal)
                Request.Parameters.Add("units", metric.ToString().ToLowerInvariant());

            if (language != OpenWeatherMapLanguage.EN)
                Request.Parameters.Add("lang", language.ToString().ToLowerInvariant());

            if (count.HasValue)
            {
                Request.Parameters.Add("cnt", count.Value.ToString(CultureInfo.InvariantCulture));
            }
            if (accuracy.HasValue)
            {
                Request.Parameters.Add("type", accuracy.Value.ToString().ToLowerInvariant());
            }

            return RunGetRequest<T>();
        }

        /// <summary>
        /// Gets by city identifier.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cityId">The city identifier.</param>
        /// <param name="metric">The metric.</param>
        /// <param name="language">The language.</param>
        /// <param name="count">The count.</param>
        /// <returns>Task{``0}.</returns>
        internal Task<T> GetByCityId<T>(int cityId, MetricSystem metric, OpenWeatherMapLanguage language, int? count)
        {
            Ensure.ArgumentNotNull(metric, "metric");
            Ensure.ArgumentNotNull(language, "language");

            Request.Parameters.Add("id", cityId.ToString(CultureInfo.InvariantCulture));

            if (metric != MetricSystem.Internal)
                Request.Parameters.Add("units", metric.ToString().ToLowerInvariant());

            if (language != OpenWeatherMapLanguage.EN)
                Request.Parameters.Add("lang", language.ToString().ToLowerInvariant());

            if (count.HasValue)
            {
                Request.Parameters.Add("cnt", count.Value.ToString(CultureInfo.InvariantCulture));
            }
            return RunGetRequest<T>();
        }

        /// <summary>
        /// Runs the get request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Task{``0}.</returns>
        Task<T> RunGetRequest<T>()
        {
            Request.Parameters.Add("mode", "xml");
            var uri = Request.Uri.AddQuery(Request.Parameters.ToUrlParameters());
            Request.Request = new HttpRequestMessage(HttpMethod.Get, uri);

            return Send<T>();
        }

        /// <summary>
        /// Sends the request.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns>Task{T}.</returns>
        /// <exception cref="OpenWeatherMap.OpenWeatherMapException">
        /// </exception>
        async Task<T> Send<T>()
        {
            HttpResponseMessage response;
            try
            {
                response = await Request.HttpClient.SendAsync(Request.Request);
            }
            catch (Exception ex)
            {
                throw new OpenWeatherMapException(ex);
            }

            if (!response.IsSuccessStatusCode)
            {
                throw new OpenWeatherMapException(response);
            }

            var responseString = await response.Content.ReadAsStringAsync();
            // OpenWeatherMap returns errors with json
            if (string.IsNullOrEmpty(responseString) || responseString.StartsWith("{"))
            {
                throw new OpenWeatherMapException(response);
            }
            var responseStream = await response.Content.ReadAsStreamAsync();
            var xmlSerializer = new XmlSerializer(typeof(T));
            var xmlReader = XmlReader.Create(responseStream);
            if (xmlSerializer.CanDeserialize(xmlReader))
            {
                return (T)xmlSerializer.Deserialize(xmlReader);
            }
            throw new OpenWeatherMapException(response);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ApiClientBase"/> class.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="segment">The segment.</param>
        protected ApiClientBase(IOpenWeatherMapRequest request, string segment)
        {
            request.Uri = request.Uri.AddSegment(segment);
            Request = request;
        }
    }
}
