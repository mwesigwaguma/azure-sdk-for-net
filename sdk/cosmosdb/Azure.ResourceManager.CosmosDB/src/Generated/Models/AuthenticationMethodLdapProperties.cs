// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Ldap authentication method properties. This feature is in preview. </summary>
    public partial class AuthenticationMethodLdapProperties
    {
        /// <summary> Initializes a new instance of AuthenticationMethodLdapProperties. </summary>
        public AuthenticationMethodLdapProperties()
        {
            ServerCertificates = new ChangeTrackingList<CassandraCertificate>();
        }

        /// <summary> Initializes a new instance of AuthenticationMethodLdapProperties. </summary>
        /// <param name="serverHostname"> Hostname of the LDAP server. </param>
        /// <param name="serverPort"> Port of the LDAP server. </param>
        /// <param name="serviceUserDistinguishedName"> Distinguished name of the look up user account, who can look up user details on authentication. </param>
        /// <param name="serviceUserPassword"> Password of the look up user. </param>
        /// <param name="searchBaseDistinguishedName"> Distinguished name of the object to start the recursive search of users from. </param>
        /// <param name="searchFilterTemplate"> Template to use for searching. Defaults to (cn=%s) where %s will be replaced by the username used to login. </param>
        /// <param name="serverCertificates"></param>
        internal AuthenticationMethodLdapProperties(string serverHostname, int? serverPort, string serviceUserDistinguishedName, string serviceUserPassword, string searchBaseDistinguishedName, string searchFilterTemplate, IList<CassandraCertificate> serverCertificates)
        {
            ServerHostname = serverHostname;
            ServerPort = serverPort;
            ServiceUserDistinguishedName = serviceUserDistinguishedName;
            ServiceUserPassword = serviceUserPassword;
            SearchBaseDistinguishedName = searchBaseDistinguishedName;
            SearchFilterTemplate = searchFilterTemplate;
            ServerCertificates = serverCertificates;
        }

        /// <summary> Hostname of the LDAP server. </summary>
        public string ServerHostname { get; set; }
        /// <summary> Port of the LDAP server. </summary>
        public int? ServerPort { get; set; }
        /// <summary> Distinguished name of the look up user account, who can look up user details on authentication. </summary>
        public string ServiceUserDistinguishedName { get; set; }
        /// <summary> Password of the look up user. </summary>
        public string ServiceUserPassword { get; set; }
        /// <summary> Distinguished name of the object to start the recursive search of users from. </summary>
        public string SearchBaseDistinguishedName { get; set; }
        /// <summary> Template to use for searching. Defaults to (cn=%s) where %s will be replaced by the username used to login. </summary>
        public string SearchFilterTemplate { get; set; }
        /// <summary> Gets the server certificates. </summary>
        public IList<CassandraCertificate> ServerCertificates { get; }
    }
}
