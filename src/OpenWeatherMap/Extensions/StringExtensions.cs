// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-19-2014
// ***********************************************************************
// <copyright file="StringExtensions.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class StringExtensions.
    /// </summary>
    internal static class StringExtensions
    {
        /// <summary>
        ///  encode string to be URL friendly.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns>System.String.</returns>
        public static string UrlEncode(this string input)
        {
            return Uri.EscapeDataString(input);
        }
    }
}
