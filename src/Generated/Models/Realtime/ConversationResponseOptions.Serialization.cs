// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using OpenAI;

namespace OpenAI.Realtime
{
    public partial class ConversationResponseOptions : IJsonModel<ConversationResponseOptions>
    {
        void IJsonModel<ConversationResponseOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationResponseOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationResponseOptions)} does not support writing '{format}' format.");
            }
            if (Optional.IsDefined(Instructions) && _additionalBinaryDataProperties?.ContainsKey("instructions") != true)
            {
                writer.WritePropertyName("instructions"u8);
                writer.WriteStringValue(Instructions);
            }
            if (Optional.IsDefined(OutputAudioFormat) && _additionalBinaryDataProperties?.ContainsKey("output_audio_format") != true)
            {
                writer.WritePropertyName("output_audio_format"u8);
                writer.WriteStringValue(OutputAudioFormat.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Tools) && _additionalBinaryDataProperties?.ContainsKey("tools") != true)
            {
                writer.WritePropertyName("tools"u8);
                writer.WriteStartArray();
                foreach (ConversationTool item in Tools)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Temperature) && _additionalBinaryDataProperties?.ContainsKey("temperature") != true)
            {
                writer.WritePropertyName("temperature"u8);
                writer.WriteNumberValue(Temperature.Value);
            }
            if (Optional.IsCollectionDefined(Metadata) && _additionalBinaryDataProperties?.ContainsKey("metadata") != true)
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartObject();
                foreach (var item in Metadata)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ConversationSelection) && _additionalBinaryDataProperties?.ContainsKey("conversation") != true)
            {
                writer.WritePropertyName("conversation"u8);
                writer.WriteStringValue(ConversationSelection.Value.ToString());
            }
            if (Optional.IsDefined(MaxOutputTokens) && _additionalBinaryDataProperties?.ContainsKey("max_output_tokens") != true)
            {
                writer.WritePropertyName("max_output_tokens"u8);
                writer.WriteObjectValue(MaxOutputTokens, options);
            }
            if (Optional.IsCollectionDefined(OverrideItems) && _additionalBinaryDataProperties?.ContainsKey("input") != true)
            {
                writer.WritePropertyName("input"u8);
                writer.WriteStartArray();
                foreach (RealtimeItem item in OverrideItems)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Voice) && _additionalBinaryDataProperties?.ContainsKey("voice") != true)
            {
                writer.WritePropertyName("voice"u8);
                writer.WriteStringValue(Voice.Value.ToString());
            }
            if (Optional.IsCollectionDefined(_internalModalities) && _additionalBinaryDataProperties?.ContainsKey("modalities") != true)
            {
                writer.WritePropertyName("modalities"u8);
                writer.WriteStartArray();
                foreach (InternalRealtimeRequestSessionModality item in _internalModalities)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(_internalToolChoice) && _additionalBinaryDataProperties?.ContainsKey("tool_choice") != true)
            {
                writer.WritePropertyName("tool_choice"u8);
#if NET6_0_OR_GREATER
                writer.WriteRawValue(_internalToolChoice);
#else
                using (JsonDocument document = JsonDocument.Parse(_internalToolChoice))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
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

        ConversationResponseOptions IJsonModel<ConversationResponseOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => JsonModelCreateCore(ref reader, options);

        protected virtual ConversationResponseOptions JsonModelCreateCore(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationResponseOptions>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationResponseOptions)} does not support reading '{format}' format.");
            }
            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationResponseOptions(document.RootElement, options);
        }

        internal static ConversationResponseOptions DeserializeConversationResponseOptions(JsonElement element, ModelReaderWriterOptions options)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string instructions = default;
            RealtimeAudioFormat? outputAudioFormat = default;
            IList<ConversationTool> tools = default;
            float? temperature = default;
            IDictionary<string, string> metadata = default;
            ResponseConversationSelection? conversationSelection = default;
            ConversationMaxTokensChoice maxOutputTokens = default;
            IList<RealtimeItem> overrideItems = default;
            ConversationVoice? voice = default;
            IList<InternalRealtimeRequestSessionModality> internalModalities = default;
            BinaryData internalToolChoice = default;
            IDictionary<string, BinaryData> additionalBinaryDataProperties = new ChangeTrackingDictionary<string, BinaryData>();
            foreach (var prop in element.EnumerateObject())
            {
                if (prop.NameEquals("instructions"u8))
                {
                    instructions = prop.Value.GetString();
                    continue;
                }
                if (prop.NameEquals("output_audio_format"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    outputAudioFormat = new RealtimeAudioFormat(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("tools"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ConversationTool> array = new List<ConversationTool>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(ConversationTool.DeserializeConversationTool(item, options));
                    }
                    tools = array;
                    continue;
                }
                if (prop.NameEquals("temperature"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    temperature = prop.Value.GetSingle();
                    continue;
                }
                if (prop.NameEquals("metadata"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var prop0 in prop.Value.EnumerateObject())
                    {
                        if (prop0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(prop0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(prop0.Name, prop0.Value.GetString());
                        }
                    }
                    metadata = dictionary;
                    continue;
                }
                if (prop.NameEquals("conversation"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    conversationSelection = new ResponseConversationSelection(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("max_output_tokens"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxOutputTokens = ConversationMaxTokensChoice.DeserializeConversationMaxTokensChoice(prop.Value, options);
                    continue;
                }
                if (prop.NameEquals("input"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RealtimeItem> array = new List<RealtimeItem>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(RealtimeItem.DeserializeRealtimeItem(item, options));
                    }
                    overrideItems = array;
                    continue;
                }
                if (prop.NameEquals("voice"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    voice = new ConversationVoice(prop.Value.GetString());
                    continue;
                }
                if (prop.NameEquals("modalities"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<InternalRealtimeRequestSessionModality> array = new List<InternalRealtimeRequestSessionModality>();
                    foreach (var item in prop.Value.EnumerateArray())
                    {
                        array.Add(new InternalRealtimeRequestSessionModality(item.GetString()));
                    }
                    internalModalities = array;
                    continue;
                }
                if (prop.NameEquals("tool_choice"u8))
                {
                    if (prop.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internalToolChoice = BinaryData.FromString(prop.Value.GetRawText());
                    continue;
                }
                // Plugin customization: remove options.Format != "W" check
                additionalBinaryDataProperties.Add(prop.Name, BinaryData.FromString(prop.Value.GetRawText()));
            }
            return new ConversationResponseOptions(
                instructions,
                outputAudioFormat,
                tools ?? new ChangeTrackingList<ConversationTool>(),
                temperature,
                metadata ?? new ChangeTrackingDictionary<string, string>(),
                conversationSelection,
                maxOutputTokens,
                overrideItems ?? new ChangeTrackingList<RealtimeItem>(),
                voice,
                internalModalities,
                internalToolChoice,
                additionalBinaryDataProperties);
        }

        BinaryData IPersistableModel<ConversationResponseOptions>.Write(ModelReaderWriterOptions options) => PersistableModelWriteCore(options);

        protected virtual BinaryData PersistableModelWriteCore(ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationResponseOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options, OpenAIContext.Default);
                default:
                    throw new FormatException($"The model {nameof(ConversationResponseOptions)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationResponseOptions IPersistableModel<ConversationResponseOptions>.Create(BinaryData data, ModelReaderWriterOptions options) => PersistableModelCreateCore(data, options);

        protected virtual ConversationResponseOptions PersistableModelCreateCore(BinaryData data, ModelReaderWriterOptions options)
        {
            string format = options.Format == "W" ? ((IPersistableModel<ConversationResponseOptions>)this).GetFormatFromOptions(options) : options.Format;
            switch (format)
            {
                case "J":
                    using (JsonDocument document = JsonDocument.Parse(data))
                    {
                        return DeserializeConversationResponseOptions(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationResponseOptions)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationResponseOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
