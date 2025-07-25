// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsCodeOutputImageObjectImage : IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>
    {
        internal InternalRunStepDetailsToolCallsCodeOutputImageObjectImage()
        {
        }

        void IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support writing '{format}' format.");
            }
            if (_additionalBinaryDataProperties?.ContainsKey("file_id") != true)
            {
                writer.WritePropertyName("file_id"u8);
                writer.WriteStringValue(FileId);
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

        InternalRunStepDetailsToolCallsCodeOutputImageObjectImage IJsonModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual InternalRunStepDetailsToolCallsCodeOutputImageObjectImage JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement, options);
        }

        internal static InternalRunStepDetailsToolCallsCodeOutputImageObjectImage DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string fileId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("file_id"u8))
                {
                    fileId = prop.Value.GetString();
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRunStepDetailsToolCallsCodeOutputImageObjectImage(fileId, additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRunStepDetailsToolCallsCodeOutputImageObjectImage IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual InternalRunStepDetailsToolCallsCodeOutputImageObjectImage PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRunStepDetailsToolCallsCodeOutputImageObjectImage(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRunStepDetailsToolCallsCodeOutputImageObjectImage)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRunStepDetailsToolCallsCodeOutputImageObjectImage>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
