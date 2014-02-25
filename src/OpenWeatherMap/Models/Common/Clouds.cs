// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="Clouds.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Clouds.
    /// </summary>
    public class Clouds
    {
        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>The value.</value>
        [XmlAttribute("value")]
        public int Value { get; set; }

        /// <summary>
        /// Gets or sets the name (e.g. broken clouds).
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("name")]
        public string Name { get; set; }
    }
}
