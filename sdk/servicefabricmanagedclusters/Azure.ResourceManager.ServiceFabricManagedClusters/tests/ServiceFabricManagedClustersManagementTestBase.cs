// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Tests
{
    public class ServiceFabricManagedClustersManagementTestBase : ManagementRecordedTestBase<ServiceFabricManagedClustersManagementTestEnvironment>
    {
        protected const string clusterName = "sfmc-managed-test-cluster";
        protected ArmClient Client { get; private set; }
        protected ResourceIdentifier resourceIdentifier { get; private set; }
        private const string OneBoxSubscriptionId = "1B081B08-1B08-1B08-1B08-1B081B081B08";
        protected const string resourceId = $"/subscriptions/{OneBoxSubscriptionId}/resourcegroups/{OneBoxSubscriptionId}/providers/Microsoft.ServiceFabric/managedclusters/{clusterName}";

        protected ServiceFabricManagedClustersManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
        }

        protected ServiceFabricManagedClustersManagementTestBase(bool isAsync)
            : base(isAsync)
        {
        }

        public ArmOperation<ServiceFabricManagedClusterResource> createClusterResource()
        {
            Client = GetArmClient();
            resourceIdentifier = new ResourceIdentifier(resourceId);
            ServiceFabricManagedClusterData data = new ServiceFabricManagedClusterData(AzureLocation.CentralUS);

            ServiceFabricManagedClusterCollection sfmcCollection =  new ServiceFabricManagedClusterCollection(Client, resourceIdentifier);
            return sfmcCollection.CreateOrUpdate(WaitUntil.Completed, clusterName, data, CancellationToken.None);
        }
    }
}
