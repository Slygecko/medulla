// Licensed to the Medulla Contributors under one or more agreements.
// The Medulla Contributors licenses this file to you under the Apache 2.0 license.
// See the LICENSE file in the project root for more information.

namespace Medulla.Components.Library;

/// <summary>
/// IsComponent lets the Medulla system know that the class will be pulled into the Medulla Editor as a component.
/// </summary>
[System.AttributeUsage(System.AttributeTargets.Class |
                       System.AttributeTargets.Struct)]
public class IsComponent : System.Attribute
{
    /// <summary>
    /// Version of component
    /// </summary>
    public double version;

    /// <summary>
    /// Name of this component
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description of this component
    /// </summary>
    public string Description { get; set; }

    /// <summary>
    /// Constructor for component
    /// </summary>
    /// <param name="name"></param>
    /// <param name="description"></param>
    public IsComponent(string name, string description)
    {
        version = 1.0;
        this.Name = name;
        this.Description = description;
    }
}
