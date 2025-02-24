﻿// ---------------------------------------------------------------
// Copyright (c) 2023 Planet Dotnet. All rights reserved.
// Licensed under the MIT License.
// See License.txt in the project root for license information.
// ---------------------------------------------------------------

using System;

namespace PlanetDotnet.Portal.Models.Views.PreviewViews.Exceptions
{
    public class PreviewViewDependencyException : Exception
    {
        public PreviewViewDependencyException(Exception innerException)
            : base("Preview view dependency error occurred, contact support.", innerException)
        { }
    }
}
