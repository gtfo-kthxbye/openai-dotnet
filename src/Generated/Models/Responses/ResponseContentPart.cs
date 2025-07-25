// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Responses
{
    [Experimental("OPENAI001")]
    public partial class ResponseContentPart
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        private protected ResponseContentPart(InternalItemContentType internalType)
        {
            InternalType = internalType;
        }

        internal ResponseContentPart(InternalItemContentType internalType, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            InternalType = internalType;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
