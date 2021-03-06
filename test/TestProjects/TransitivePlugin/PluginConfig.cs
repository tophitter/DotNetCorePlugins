// Copyright (c) Nate McMaster.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Test.Transitive;

namespace TransitivePlugin
{
    public class PluginConfig
    {
        public TransitiveSharedType GetTransitiveType() => new();
    }
}
