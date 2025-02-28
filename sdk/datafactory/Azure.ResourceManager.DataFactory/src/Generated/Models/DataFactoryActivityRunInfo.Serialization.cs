// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class DataFactoryActivityRunInfo
    {
        internal static DataFactoryActivityRunInfo DeserializeDataFactoryActivityRunInfo(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> pipelineName = default;
            Optional<Guid> pipelineRunId = default;
            Optional<string> activityName = default;
            Optional<string> activityType = default;
            Optional<Guid> activityRunId = default;
            Optional<string> linkedServiceName = default;
            Optional<string> status = default;
            Optional<DateTimeOffset> activityRunStart = default;
            Optional<DateTimeOffset> activityRunEnd = default;
            Optional<int> durationInMs = default;
            Optional<BinaryData> input = default;
            Optional<BinaryData> output = default;
            Optional<BinaryData> error = default;
            IReadOnlyDictionary<string, BinaryData> additionalProperties = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pipelineName"u8))
                {
                    pipelineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("pipelineRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pipelineRunId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("activityName"u8))
                {
                    activityName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityType"u8))
                {
                    activityType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("linkedServiceName"u8))
                {
                    linkedServiceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("activityRunStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunStart = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("activityRunEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    activityRunEnd = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("durationInMs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durationInMs = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("input"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    input = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("output"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    output = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DataFactoryActivityRunInfo(pipelineName.Value, Optional.ToNullable(pipelineRunId), activityName.Value, activityType.Value, Optional.ToNullable(activityRunId), linkedServiceName.Value, status.Value, Optional.ToNullable(activityRunStart), Optional.ToNullable(activityRunEnd), Optional.ToNullable(durationInMs), input.Value, output.Value, error.Value, additionalProperties);
        }
    }
}
