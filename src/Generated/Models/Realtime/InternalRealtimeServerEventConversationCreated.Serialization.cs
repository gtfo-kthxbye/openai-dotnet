// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    internal partial class InternalRealtimeServerEventConversationCreated : IJsonModel<InternalRealtimeServerEventConversationCreated>
    {
        internal InternalRealtimeServerEventConversationCreated() : this(RealtimeUpdateKind.ConversationCreated, null, null, null)
        {
        }

        void IJsonModel<InternalRealtimeServerEventConversationCreated>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventConversationCreated>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeServerEventConversationCreated)} does not support writing '{format}' format.");
            }
            base.JsonModelWriteCore(writer, options);
            if (_additionalBinaryDataProperties?.ContainsKey("conversation") != true)
            {
                writer.WritePropertyName("conversation"u8);
                writer.WriteObjectValue(Conversation, options);
            }
        }

        InternalRealtimeServerEventConversationCreated IJsonModel<InternalRealtimeServerEventConversationCreated>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => (InternalRealtimeServerEventConversationCreated)JsonModelCreateCore(ref reader, options);

        protected override RealtimeUpdate JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventConversationCreated>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(InternalRealtimeServerEventConversationCreated)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInternalRealtimeServerEventConversationCreated(document.RootElement, options);
        }

        internal static InternalRealtimeServerEventConversationCreated DeserializeInternalRealtimeServerEventConversationCreated(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RealtimeUpdateKind kind = default;
            string eventId = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            InternalRealtimeServerEventConversationCreatedConversation conversation = default;
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("type"u8))
                {
                    kind = prop.Value.GetString().ToRealtimeUpdateKind();
                    continue;
                }
                if (prop.NameEquals("event_id"u8))
                {
                    eventId = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("conversation"u8))
                {
                    conversation = InternalRealtimeServerEventConversationCreatedConversation.DeserializeInternalRealtimeServerEventConversationCreatedConversation(prop.Value, options);
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new InternalRealtimeServerEventConversationCreated(kind, eventId, additionalBinaryDataProperties, conversation);
        }

        BinaryData IPersistableModel<InternalRealtimeServerEventConversationCreated>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected override BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventConversationCreated>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeServerEventConversationCreated)} does not support writing '{options.Format}' format.");
            }
        }

        InternalRealtimeServerEventConversationCreated IPersistableModel<InternalRealtimeServerEventConversationCreated>.Create(BinaryData data, ModelReaderWriterOptions options) => (InternalRealtimeServerEventConversationCreated)PersistableModelCreateCore(data, options);

        protected override RealtimeUpdate PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<InternalRealtimeServerEventConversationCreated>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeInternalRealtimeServerEventConversationCreated(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(InternalRealtimeServerEventConversationCreated)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<InternalRealtimeServerEventConversationCreated>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
