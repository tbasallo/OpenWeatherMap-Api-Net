// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="Location.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Location.
    /// </summary>
    public class Location
    {
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        [XmlElement("country")]
        public string Country { get; set; }

        /// <summary>
        /// Gets or sets the time zone.
        /// </summary>
        /// <value>The time zone.</value>
        [XmlElement("timezone")]
        public string TimeZone { get; set; }

        /// <summary>
        /// Gets or sets the city location.
        /// </summary>
        /// <value>The city location.</value>
        [XmlElement("location")]
        public CityLocation CityLocation { get; set; }
    }
}
