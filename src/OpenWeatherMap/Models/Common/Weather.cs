// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="Weather.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Weather.
    /// </summary>
    public class Weather
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        [XmlAttribute("number")]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlAttribute("value")]
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the icon filename without extension.
        /// </summary>
        /// <value>The icon.</value>
        [XmlAttribute("icon")]
        public string Icon { get; set; }
    }
}
