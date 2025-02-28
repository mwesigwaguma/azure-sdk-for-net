// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Communication.Chat
{
    /// <summary> Request payload for creating a chat thread. </summary>
    internal partial class CreateChatThreadRequest
    {
        /// <summary> Initializes a new instance of CreateChatThreadRequest. </summary>
        /// <param name="topic"> The chat thread topic. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="topic"/> is null. </exception>
        public CreateChatThreadRequest(string topic)
        {
            Argument.AssertNotNull(topic, nameof(topic));

            Topic = topic;
            Participants = new ChangeTrackingList<ChatParticipantInternal>();
        }

        /// <summary> The chat thread topic. </summary>
        public string Topic { get; }
        /// <summary> Participants to be added to the chat thread. </summary>
        public IList<ChatParticipantInternal> Participants { get; }
    }
}
