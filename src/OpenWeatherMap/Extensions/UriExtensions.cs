// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-21-2014
// ***********************************************************************
// <copyright file="UriExtensions.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class UriExtensions.
    /// </summary>
    internal static class UriExtensions
    {
        /// <summary>
        /// Adds the segment value to the url.
        /// </summary>
        /// <param name="originalUri">The original URI.</param>
        /// <param name="segment">The segment.</param>
        /// <returns>Uri.</returns>
        public static Uri AddSegment(this Uri originalUri, string segment)
        {
            originalUri = new Uri(originalUri.OriginalString + "/" + segment);
            return originalUri;
        }

        /// <summary>
        /// Adds the query value to the url.
        /// </summary>
        /// <param name="originalUri">The original URI.</param>
        /// <param name="segment">The segment.</param>
        /// <returns>Uri.</returns>
        public static Uri AddQuery(this Uri originalUri, string segment)
        {
            var uriBuilder = new UriBuilder(originalUri)
            {
                Query = segment
            };
            originalUri = uriBuilder.Uri;
            return originalUri;
        }
    }
}
