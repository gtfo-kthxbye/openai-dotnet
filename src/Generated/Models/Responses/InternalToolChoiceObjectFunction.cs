// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalToolChoiceObjectFunction : InternalToolChoiceObject
    {
        public InternalToolChoiceObjectFunction(string name) : base(InternalToolChoiceObjectType.Function)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        internal InternalToolChoiceObjectFunction(InternalToolChoiceObjectType kind, IDictionary<string, BinaryData> additionalBinaryDataProperties, string name) : base(kind, additionalBinaryDataProperties)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
