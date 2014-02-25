// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-19-2014
// ***********************************************************************
// <copyright file="OpenWeatherMapException.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

using System;
using System.Net;
using System.Net.Http;

namespace OpenWeatherMap
{
    /// <summary>
    /// Class OpenWeatherMapException.
    /// </summary>
    public class OpenWeatherMapException : Exception
    {
        /// <summary>
        /// Gets the response message.
        /// </summary>
        /// <value>The response.</value>
        public HttpResponseMessage Response { get; private set; }

        /// <summary>
        /// Gets the status code.
        /// </summary>
        /// <value>The status code.</value>
        public HttpStatusCode StatusCode { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        public OpenWeatherMapException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        /// <param name="status">The status.</param>
        public OpenWeatherMapException(HttpStatusCode status)
        {
            StatusCode = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        /// <param name="response">The response.</param>
        public OpenWeatherMapException(HttpResponseMessage response)
            : this(response.StatusCode)
        {
            Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OpenWeatherMapException"/> class.
        /// </summary>
        /// <param name="ex">The ex.</param>
        public OpenWeatherMapException(Exception ex)
            : base("OpenWeatherMap : an error occurred", ex)
        {
        }
    }
}
