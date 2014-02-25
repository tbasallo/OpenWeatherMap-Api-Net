// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-20-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-20-2014
// ***********************************************************************
// <copyright file="Symbol.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System.Xml.Serialization;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Symbol (weather detail).
    /// </summary>
    public class Symbol
    {
        /// <summary>
        /// Gets or sets the number.
        /// </summary>
        /// <value>The number.</value>
        [XmlAttribute("number")]
        public int Number { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>The name.</value>
        [XmlAttribute("name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the variable.
        /// </summary>
        /// <value>The variable.</value>
        [XmlAttribute("var")]
        public string Var { get; set; }
    }
}
