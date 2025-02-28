// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class IPCommunityListPropertiesEvpnEsImportRouteTargetsItem : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("evpnEsImportRouteTarget"u8);
            writer.WriteStringValue(EvpnEsImportRouteTarget);
            if (Optional.IsDefined(Annotation))
            {
                writer.WritePropertyName("annotation"u8);
                writer.WriteStringValue(Annotation);
            }
            writer.WriteEndObject();
        }

        internal static IPCommunityListPropertiesEvpnEsImportRouteTargetsItem DeserializeIPCommunityListPropertiesEvpnEsImportRouteTargetsItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string evpnEsImportRouteTarget = default;
            Optional<string> annotation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("evpnEsImportRouteTarget"u8))
                {
                    evpnEsImportRouteTarget = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("annotation"u8))
                {
                    annotation = property.Value.GetString();
                    continue;
                }
            }
            return new IPCommunityListPropertiesEvpnEsImportRouteTargetsItem(annotation.Value, evpnEsImportRouteTarget);
        }
    }
}
