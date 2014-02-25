// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-19-2014
// ***********************************************************************
// <copyright file="DictionnaryExtensions.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class DictionnaryExtensions.
    /// </summary>
    internal static class DictionnaryExtensions
    {
        /// <summary>
        /// Transform the dictionnary into URL parameters.
        /// </summary>
        /// <param name="parameters">The parameters.</param>
        /// <returns>System.String.</returns>
        public static string ToUrlParameters(this IDictionary<string, string> parameters)
        {
            var array = parameters.Select(
                x => string.Format("{0}={1}", Uri.EscapeUriString(x.Key), Uri.EscapeUriString(x.Value))).ToArray();
            return string.Join("&", array);
        }
    }
}
