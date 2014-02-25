// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="Temperature.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Temperature.
    /// </summary>
    public class Temperature
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlAttribute("value")]
        public double Value { get; set; }

        /// <summary>
        /// Gets or sets the minimum.
        /// </summary>
        /// <value>The minimum.</value>
        [XmlAttribute("min")]
        public double Min { get; set; }

        /// <summary>
        /// Gets or sets the maximum.
        /// </summary>
        /// <value>The maximum.</value>
        [XmlAttribute("max")]
        public double Max { get; set; }

        /// <summary>
        /// Gets or sets the unit.
        /// </summary>
        /// <value>The unit.</value>
        [XmlAttribute("unit")]
        public string Unit { get; set; }
    }
}
