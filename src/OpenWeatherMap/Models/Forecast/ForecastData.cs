// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="ForecastData.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class ForecastData.
    /// </summary>
    public class ForecastData
    {
        /// <summary>
        /// Gets or sets the location.
        /// </summary>
        /// <value>The location.</value>
        [XmlElement("location")]
        public Location Location { get; set; }

        /// <summary>
        /// Gets or sets the meta.
        /// </summary>
        /// <value>The meta.</value>
        [XmlElement("meta")]
        public Meta Meta { get; set; }

        /// <summary>
        /// Gets or sets the sun.
        /// </summary>
        /// <value>The sun.</value>
        [XmlElement("sun")]
        public Sun Sun { get; set; }

        /// <summary>
        /// Gets or sets the forecast.
        /// </summary>
        /// <value>The forecast.</value>
        [XmlArray("forecast"), XmlArrayItem("time", Type = typeof(ForecastTime))]
        public ForecastTime[] Forecast { get; set; }
    }
}
