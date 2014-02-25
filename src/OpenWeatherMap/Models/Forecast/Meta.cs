// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-22-2014
// ***********************************************************************
// <copyright file="Meta.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Meta.
    /// </summary>
    public class Meta
    {
        /// <summary>
        /// Gets or sets the last update.
        /// </summary>
        /// <value>The last update.</value>
        [XmlElement("lastupdate")]
        public string LastUpdate { get; set; }

        /// <summary>
        /// Gets or sets the calculation time.
        /// </summary>
        /// <value>The calculation time.</value>
        [XmlElement("calctime")]
        public double CalcTime { get; set; }

        /// <summary>
        /// Gets or sets the next update.
        /// </summary>
        /// <value>The next update.</value>
        [XmlElement("nextupdate")]
        public string NextUpdate { get; set; }
    }
}
