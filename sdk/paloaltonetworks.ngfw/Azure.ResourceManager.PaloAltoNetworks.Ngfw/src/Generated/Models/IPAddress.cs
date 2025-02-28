// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw.Models
{
    /// <summary> IP Address. </summary>
    public partial class IPAddress
    {
        /// <summary> Initializes a new instance of IPAddress. </summary>
        public IPAddress()
        {
        }

        /// <summary> Initializes a new instance of IPAddress. </summary>
        /// <param name="resourceId"> Resource Id. </param>
        /// <param name="address"> Address value. </param>
        internal IPAddress(string resourceId, string address)
        {
            ResourceId = resourceId;
            Address = address;
        }

        /// <summary> Resource Id. </summary>
        public string ResourceId { get; set; }
        /// <summary> Address value. </summary>
        public string Address { get; set; }
    }
}
