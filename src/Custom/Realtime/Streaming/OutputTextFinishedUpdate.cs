using System;
using System.Collections.Generic;
using System.ClientModel.Primitives;
using System.Text.Json;
using System.Diagnostics.CodeAnalysis;

namespace OpenAI.Realtime;

/// <summary>
/// The update (response command) of type <c>response.text.done</c>, which is received after correlated
/// <see cref="OutputStreamingStartedUpdate"/> (<c>response.output_item.added</c>) and
/// <see cref="ItemCreatedUpdate"/> (<c>conversation.item.created</c>) updates.
/// This update indicates that all streamed <c>delta</c> content has completed and the associated content part will soon be completed.
/// </summary>
[CodeGenType("RealtimeServerEventResponseTextDone")]
public partial class OutputTextFinishedUpdate
{ }
