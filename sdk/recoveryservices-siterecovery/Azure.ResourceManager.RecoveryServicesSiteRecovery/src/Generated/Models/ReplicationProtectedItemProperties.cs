// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication protected item custom data details. </summary>
    public partial class ReplicationProtectedItemProperties
    {
        /// <summary> Initializes a new instance of ReplicationProtectedItemProperties. </summary>
        internal ReplicationProtectedItemProperties()
        {
            AllowedOperations = new ChangeTrackingList<string>();
            HealthErrors = new ChangeTrackingList<HealthError>();
        }

        /// <summary> Initializes a new instance of ReplicationProtectedItemProperties. </summary>
        /// <param name="friendlyName"> The name. </param>
        /// <param name="protectedItemType"> The type of protected item type. </param>
        /// <param name="protectableItemId"> The protected item ARM Id. </param>
        /// <param name="recoveryServicesProviderId"> The recovery provider ARM Id. </param>
        /// <param name="primaryFabricFriendlyName"> The friendly name of the primary fabric. </param>
        /// <param name="primaryFabricProvider"> The fabric provider of the primary fabric. </param>
        /// <param name="recoveryFabricFriendlyName"> The friendly name of recovery fabric. </param>
        /// <param name="recoveryFabricId"> The Arm Id of recovery fabric. </param>
        /// <param name="primaryProtectionContainerFriendlyName"> The name of primary protection container friendly name. </param>
        /// <param name="recoveryProtectionContainerFriendlyName"> The name of recovery container friendly name. </param>
        /// <param name="protectionState"> The protection status. </param>
        /// <param name="protectionStateDescription"> The protection state description. </param>
        /// <param name="activeLocation"> The Current active location of the PE. </param>
        /// <param name="testFailoverState"> The Test failover state. </param>
        /// <param name="testFailoverStateDescription"> The Test failover state description. </param>
        /// <param name="switchProviderState"> The switch provider state. </param>
        /// <param name="switchProviderStateDescription"> The switch provider state description. </param>
        /// <param name="allowedOperations"> The allowed operations on the Replication protected item. </param>
        /// <param name="replicationHealth"> The consolidated protection health for the VM taking any issues with SRS as well as all the replication units associated with the VM's replication group into account. This is a string representation of the ProtectionHealth enumeration. </param>
        /// <param name="failoverHealth"> The consolidated failover health for the VM. </param>
        /// <param name="healthErrors"> List of health errors. </param>
        /// <param name="policyId"> The ID of Policy governing this PE. </param>
        /// <param name="policyFriendlyName"> The name of Policy governing this PE. </param>
        /// <param name="lastSuccessfulFailoverOn"> The Last successful failover time. </param>
        /// <param name="lastSuccessfulTestFailoverOn"> The Last successful test failover time. </param>
        /// <param name="currentScenario"> The current scenario. </param>
        /// <param name="failoverRecoveryPointId"> The recovery point ARM Id to which the Vm was failed over. </param>
        /// <param name="providerSpecificDetails">
        /// The Replication provider custom settings.
        /// Please note <see cref="ReplicationProviderSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AReplicationDetails"/>, <see cref="A2ACrossClusterMigrationReplicationDetails"/>, <see cref="HyperVReplicaReplicationDetails"/>, <see cref="HyperVReplicaBlueReplicationDetails"/>, <see cref="HyperVReplicaAzureReplicationDetails"/>, <see cref="HyperVReplicaBaseReplicationDetails"/>, <see cref="InMageReplicationDetails"/>, <see cref="InMageAzureV2ReplicationDetails"/>, <see cref="InMageRcmReplicationDetails"/> and <see cref="InMageRcmFailbackReplicationDetails"/>.
        /// </param>
        /// <param name="recoveryContainerId"> The recovery container Id. </param>
        /// <param name="eventCorrelationId"> The correlation Id for events associated with this protected item. </param>
        internal ReplicationProtectedItemProperties(string friendlyName, string protectedItemType, string protectableItemId, string recoveryServicesProviderId, string primaryFabricFriendlyName, string primaryFabricProvider, string recoveryFabricFriendlyName, string recoveryFabricId, string primaryProtectionContainerFriendlyName, string recoveryProtectionContainerFriendlyName, string protectionState, string protectionStateDescription, string activeLocation, string testFailoverState, string testFailoverStateDescription, string switchProviderState, string switchProviderStateDescription, IReadOnlyList<string> allowedOperations, string replicationHealth, string failoverHealth, IReadOnlyList<HealthError> healthErrors, string policyId, string policyFriendlyName, DateTimeOffset? lastSuccessfulFailoverOn, DateTimeOffset? lastSuccessfulTestFailoverOn, CurrentScenarioDetails currentScenario, string failoverRecoveryPointId, ReplicationProviderSpecificSettings providerSpecificDetails, string recoveryContainerId, string eventCorrelationId)
        {
            FriendlyName = friendlyName;
            ProtectedItemType = protectedItemType;
            ProtectableItemId = protectableItemId;
            RecoveryServicesProviderId = recoveryServicesProviderId;
            PrimaryFabricFriendlyName = primaryFabricFriendlyName;
            PrimaryFabricProvider = primaryFabricProvider;
            RecoveryFabricFriendlyName = recoveryFabricFriendlyName;
            RecoveryFabricId = recoveryFabricId;
            PrimaryProtectionContainerFriendlyName = primaryProtectionContainerFriendlyName;
            RecoveryProtectionContainerFriendlyName = recoveryProtectionContainerFriendlyName;
            ProtectionState = protectionState;
            ProtectionStateDescription = protectionStateDescription;
            ActiveLocation = activeLocation;
            TestFailoverState = testFailoverState;
            TestFailoverStateDescription = testFailoverStateDescription;
            SwitchProviderState = switchProviderState;
            SwitchProviderStateDescription = switchProviderStateDescription;
            AllowedOperations = allowedOperations;
            ReplicationHealth = replicationHealth;
            FailoverHealth = failoverHealth;
            HealthErrors = healthErrors;
            PolicyId = policyId;
            PolicyFriendlyName = policyFriendlyName;
            LastSuccessfulFailoverOn = lastSuccessfulFailoverOn;
            LastSuccessfulTestFailoverOn = lastSuccessfulTestFailoverOn;
            CurrentScenario = currentScenario;
            FailoverRecoveryPointId = failoverRecoveryPointId;
            ProviderSpecificDetails = providerSpecificDetails;
            RecoveryContainerId = recoveryContainerId;
            EventCorrelationId = eventCorrelationId;
        }

        /// <summary> The name. </summary>
        public string FriendlyName { get; }
        /// <summary> The type of protected item type. </summary>
        public string ProtectedItemType { get; }
        /// <summary> The protected item ARM Id. </summary>
        public string ProtectableItemId { get; }
        /// <summary> The recovery provider ARM Id. </summary>
        public string RecoveryServicesProviderId { get; }
        /// <summary> The friendly name of the primary fabric. </summary>
        public string PrimaryFabricFriendlyName { get; }
        /// <summary> The fabric provider of the primary fabric. </summary>
        public string PrimaryFabricProvider { get; }
        /// <summary> The friendly name of recovery fabric. </summary>
        public string RecoveryFabricFriendlyName { get; }
        /// <summary> The Arm Id of recovery fabric. </summary>
        public string RecoveryFabricId { get; }
        /// <summary> The name of primary protection container friendly name. </summary>
        public string PrimaryProtectionContainerFriendlyName { get; }
        /// <summary> The name of recovery container friendly name. </summary>
        public string RecoveryProtectionContainerFriendlyName { get; }
        /// <summary> The protection status. </summary>
        public string ProtectionState { get; }
        /// <summary> The protection state description. </summary>
        public string ProtectionStateDescription { get; }
        /// <summary> The Current active location of the PE. </summary>
        public string ActiveLocation { get; }
        /// <summary> The Test failover state. </summary>
        public string TestFailoverState { get; }
        /// <summary> The Test failover state description. </summary>
        public string TestFailoverStateDescription { get; }
        /// <summary> The switch provider state. </summary>
        public string SwitchProviderState { get; }
        /// <summary> The switch provider state description. </summary>
        public string SwitchProviderStateDescription { get; }
        /// <summary> The allowed operations on the Replication protected item. </summary>
        public IReadOnlyList<string> AllowedOperations { get; }
        /// <summary> The consolidated protection health for the VM taking any issues with SRS as well as all the replication units associated with the VM's replication group into account. This is a string representation of the ProtectionHealth enumeration. </summary>
        public string ReplicationHealth { get; }
        /// <summary> The consolidated failover health for the VM. </summary>
        public string FailoverHealth { get; }
        /// <summary> List of health errors. </summary>
        public IReadOnlyList<HealthError> HealthErrors { get; }
        /// <summary> The ID of Policy governing this PE. </summary>
        public string PolicyId { get; }
        /// <summary> The name of Policy governing this PE. </summary>
        public string PolicyFriendlyName { get; }
        /// <summary> The Last successful failover time. </summary>
        public DateTimeOffset? LastSuccessfulFailoverOn { get; }
        /// <summary> The Last successful test failover time. </summary>
        public DateTimeOffset? LastSuccessfulTestFailoverOn { get; }
        /// <summary> The current scenario. </summary>
        public CurrentScenarioDetails CurrentScenario { get; }
        /// <summary> The recovery point ARM Id to which the Vm was failed over. </summary>
        public string FailoverRecoveryPointId { get; }
        /// <summary>
        /// The Replication provider custom settings.
        /// Please note <see cref="ReplicationProviderSpecificSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2AReplicationDetails"/>, <see cref="A2ACrossClusterMigrationReplicationDetails"/>, <see cref="HyperVReplicaReplicationDetails"/>, <see cref="HyperVReplicaBlueReplicationDetails"/>, <see cref="HyperVReplicaAzureReplicationDetails"/>, <see cref="HyperVReplicaBaseReplicationDetails"/>, <see cref="InMageReplicationDetails"/>, <see cref="InMageAzureV2ReplicationDetails"/>, <see cref="InMageRcmReplicationDetails"/> and <see cref="InMageRcmFailbackReplicationDetails"/>.
        /// </summary>
        public ReplicationProviderSpecificSettings ProviderSpecificDetails { get; }
        /// <summary> The recovery container Id. </summary>
        public string RecoveryContainerId { get; }
        /// <summary> The correlation Id for events associated with this protected item. </summary>
        public string EventCorrelationId { get; }
    }
}
