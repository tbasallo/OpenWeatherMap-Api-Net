// ***********************************************************************
// Assembly         : OpenWeatherMap
// Author           : Joan Caron
// Created          : 02-19-2014
// License          : MIT License (MIT) http://opensource.org/licenses/MIT
// Last Modified By : Joan Caron
// Last Modified On : 02-19-2014
// ***********************************************************************
// <copyright file="IApiClientBase.cs" company="Joan Caron">
//     Copyright (c) Joan Caron. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OpenWeatherMap
{
    /// <summary>
    /// Interface IApiClientBase
    /// </summary>
    public interface IApiClientBase
    {
        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        /// <value>The request.</value>
        IOpenWeatherMapRequest Request { get; set; }
    }
}
