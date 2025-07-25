// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalFunctionTool : ResponseTool
    {
        public InternalFunctionTool(string name, bool? strict, BinaryData parameters) : base(InternalToolType.Function)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(parameters, nameof(parameters));

            Name = name;
            Strict = strict;
            Parameters = parameters;
        }

        internal InternalFunctionTool(InternalToolType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string name, string description, bool? strict, BinaryData parameters) : base(kind, additionalBinaryDataProperties)
        {
            Name = name;
            Description = description;
            Strict = strict;
            Parameters = parameters;
        }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool? Strict { get; set; }
    }
}
