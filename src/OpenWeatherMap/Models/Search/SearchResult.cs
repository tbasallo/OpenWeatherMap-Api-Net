// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="SearchResult.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class SearchResult.
    /// </summary>
    public class SearchResult
    {
        /// <summary>
        /// Gets or sets the calculation time.
        /// </summary>
        /// <value>The calculation time.</value>
        [XmlElement("calctime")]
        public double CalcTime { get; set; }

        /// <summary>
        /// Gets or sets the result count.
        /// </summary>
        /// <value>The count.</value>
        [XmlElement("count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets the mode.
        /// </summary>
        /// <value>The mode.</value>
        [XmlElement("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// Gets or sets the list.
        /// </summary>
        /// <value>The list.</value>
        [XmlArray("list"), XmlArrayItem("item", Type = typeof(WeatherItem))]
        public WeatherItem[] List { get; set; }
    }
}
