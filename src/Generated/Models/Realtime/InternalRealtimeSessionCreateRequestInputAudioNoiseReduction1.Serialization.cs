// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 : IJsonModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>
    {
        void IJsonModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Kind) && _additionalBinaryDataProperties?.ContainsKey("type") != true)
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            // Plugin customization: remove options.Format != "W" check
            if (_additionalBinaryDataProperties != null)
            {
                foreach (var item in _additionalBinaryDataProperties)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
                    writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
        }

        InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 IJsonModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeSessionCreateRequestInputAudioNoiseReduction1(document.RootElement, options);
        }

        internal static InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 DeserializeInternalRealtimeSessionCreateRequestInputAudioNoiseReduction1(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalRealtimeSessionCreateRequestInputAudioNoiseReductionType? kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new InternalRealtimeSessionCreateRequestInputAudioNoiseReductionType(prop.Value.GetString());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1(kind, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1 PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeSessionCreateRequestInputAudioNoiseReduction1(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeSessionCreateRequestInputAudioNoiseReduction1>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
