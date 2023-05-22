// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Tests
{
    public class ManagedClusterTests : ServiceFabricManagedClustersManagementTestBase
    {
        public ManagedClusterTests(bool isAsync) : base(isAsync, RecordedTestMode.Record)
        {
        }

        [RecordedTest]
        public async Task clusterTest()
        {
            createClusterResource();

            //TokenCredential cred = new DefaultAzureCredential();
            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            ServiceFabricManagedClusterCollection collection = resourceGroupResource.GetServiceFabricManagedClusters();

            // invoke the operation
            ServiceFabricManagedClusterResource result = await collection.GetAsync(clusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedClusterData resourceData = result.Data;
            Assert.AreEqual("Ready", resourceData.ClusterState.ToString());
        }
    }
}
