// Copyright (c) Autofac Project. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using System;

namespace Autofac.Integration.AspNetCore.Multitenant.Test.TestDependencies
{
    public class ScopedDependency : IScopedDependency
    {
        public ScopedDependency()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; }
    }
}
