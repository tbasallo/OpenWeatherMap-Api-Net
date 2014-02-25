// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="ForecastClouds.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class ForecastClouds.
    /// </summary>
    public class ForecastClouds
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets all value.
        /// </summary>
        /// <value>All.</value>
        [XmlAttribute("all")]
        public int All { get; set; }

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        /// <value>The unit.</value>
        [XmlAttribute("unit")]
        public string Unit { get; set; }
    }
}
