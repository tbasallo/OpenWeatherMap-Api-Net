// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-19-2014
// ***********************************************************************
// <copyright file="Ensure.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class Ensure.
    /// </summary>
    internal static class Ensure
    {
        /// <summary>
        /// Ensure that the Argument value is not null.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        public static void ArgumentNotNull(object value, string name)
        {
            if (value != null) return;

            throw new ArgumentNullException(name);
        }

        /// <summary>
        /// Ensure that the string value is not null or empty .
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="name">The name.</param>
        /// <exception cref="System.ArgumentException">String cannot be empty</exception>
        public static void ArgumentNotNullOrEmptyString(string value, string name)
        {
            ArgumentNotNull(value, name);
            if (!string.IsNullOrEmpty(value)) return;

            throw new ArgumentException("String cannot be empty", name);
        }
    }
}
