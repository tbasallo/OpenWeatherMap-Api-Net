// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="CityLocation.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class CityLocation.
    /// </summary>
    public class CityLocation
    {
        /// <summary>
        /// Gets or sets the altitude.
        /// </summary>
        /// <value>The altitude.</value>
        [XmlAttribute("altitude")]
        public double Altitude { get; set; }

        /// <summary>
        /// Gets or sets the latitude.
        /// </summary>
        /// <value>The latitude.</value>
        [XmlAttribute("latitude")]
        public double Latitude { get; set; }

        /// <summary>
        /// Gets or sets the longitude.
        /// </summary>
        /// <value>The longitude.</value>
        [XmlAttribute("longitude")]
        public double Longitude { get; set; }

        /// <summary>
        /// Gets or sets the geo base.
        /// </summary>
        /// <value>The geo base.</value>
        [XmlAttribute("geobase")]
        public string GeoBase { get; set; }

        /// <summary>
        /// Gets or sets the geo base identifier.
        /// </summary>
        /// <value>The geo base identifier.</value>
        [XmlAttribute("geobaseid")]
        public int GeoBaseId { get; set; }
    }
}
