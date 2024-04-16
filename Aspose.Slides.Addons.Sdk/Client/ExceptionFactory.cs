//Copyright (c) 2001-2024 Aspose Pty Ltd. All Rights Reserved


using System;

namespace Aspose.Slides.Addons.Sdk.Client
{
    /// <summary>
    /// A delegate to ExceptionFactory method
    /// </summary>
    /// <param name="methodName">Method name</param>
    /// <param name="response">Response</param>
    /// <returns>Exceptions</returns>
    public delegate Exception ExceptionFactory(string methodName, IApiResponse response);
}
