// Licensed to the Medulla Contributors under one or more agreements.
// The Medulla Contributors licenses this file to you under the Apache 2.0 license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Components;

namespace Medulla.Components.Library;

/// <summary>
/// This component tests
/// </summary>
[IsComponent("TestComponent", "This is a test component")]
public partial class Component1
{

    /// <summary>
    /// This field just tests a parameter in the blazor html
    /// </summary>
    [Parameter]
    public string Test { get; set; } = "Test";

}
