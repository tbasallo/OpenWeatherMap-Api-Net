// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="Sun.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Sun.
    /// </summary>
    public class Sun
    {
        /// <summary>
        /// Gets or sets the sunrise time.
        /// </summary>
        /// <value>The rise.</value>
        [XmlAttribute("rise")]
        public DateTime Rise { get; set; }

        /// <summary>
        /// Gets or sets the sunset time.
        /// </summary>
        /// <value>The set.</value>
        [XmlAttribute("set")]
        public DateTime Set { get; set; }
    }
}
