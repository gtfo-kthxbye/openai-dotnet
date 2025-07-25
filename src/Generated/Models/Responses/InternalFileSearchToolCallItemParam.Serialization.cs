// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Responses
{
    internal partial class InternalFileSearchToolCallItemParam : IJsonModel<InternalFileSearchToolCallItemParam>
    {
        internal InternalFileSearchToolCallItemParam() : this(InternalItemType.FileSearchCall, null, null, null)
        {
        }

        void IJsonModel<InternalFileSearchToolCallItemParam>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFileSearchToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFileSearchToolCallItemParam)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("queries") != true)
            {
                writer.WritePropertyName("queries"u8);
                writer.WriteStartArray();
                foreach (string item in Queries)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Results) && _additionalBinaryDataProperties?.ContainsKey("results") != true)
            {
                writer.WritePropertyName("results"u8);
                writer.WriteStartArray();
                foreach (FileSearchCallResult item in Results)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
        }

        InternalFileSearchToolCallItemParam IJsonModel<InternalFileSearchToolCallItemParam>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalFileSearchToolCallItemParam)JsonModelCreateCore(ref reader, options);

        protected override InternalItemParam JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFileSearchToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalFileSearchToolCallItemParam)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalFileSearchToolCallItemParam(document.RootElement, options);
        }

        internal static InternalFileSearchToolCallItemParam DeserializeInternalFileSearchToolCallItemParam(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InternalItemType kind = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            IList<string> queries = default;
            IList<FileSearchCallResult> results = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = new InternalItemType(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("queries"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    queries = array;
                    continue;
                }
                if (prop.NameEquals("results"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FileSearchCallResult> array = new List<FileSearchCallResult>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(FileSearchCallResult.DeserializeFileSearchCallResult(item, options));
                    }
                    results = array;
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalFileSearchToolCallItemParam(kind, additionalBinaryDataProperties, queries, results ?? new ChangeTrackingList<FileSearchCallResult>());
        }

        BinaryData IPersistableModel<InternalFileSearchToolCallItemParam>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFileSearchToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalFileSearchToolCallItemParam)} does not support writing '{options.Format}' format.");
            }
        }

        InternalFileSearchToolCallItemParam IPersistableModel<InternalFileSearchToolCallItemParam>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalFileSearchToolCallItemParam)PersistableModelCreateCore(data, options);

        protected override InternalItemParam PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalFileSearchToolCallItemParam>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalFileSearchToolCallItemParam(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalFileSearchToolCallItemParam)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalFileSearchToolCallItemParam>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
