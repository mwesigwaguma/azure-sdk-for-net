// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    public partial class ComponentSetup : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(CustomSetupBaseType);
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("componentName"u8);
            writer.WriteStringValue(ComponentName);
            if (Optional.IsDefined(LicenseKey))
            {
                writer.WritePropertyName("licenseKey"u8);
                writer.WriteObjectValue(LicenseKey);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ComponentSetup DeserializeComponentSetup(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            string componentName = default;
            Optional<DataFactorySecretBaseDefinition> licenseKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("componentName"u8))
                        {
                            componentName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("licenseKey"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            licenseKey = DataFactorySecretBaseDefinition.DeserializeDataFactorySecretBaseDefinition(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ComponentSetup(type, componentName, licenseKey.Value);
        }
    }
}
