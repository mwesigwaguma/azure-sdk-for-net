// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Identity;
using Azure.ResourceManager;
using Azure.ResourceManager.MachineLearningCompute;
using Azure.ResourceManager.MachineLearningCompute.Models;
using Azure.ResourceManager.Resources;

namespace Azure.ResourceManager.MachineLearningCompute.Samples
{
    public partial class Sample_OperationalizationClusterCollection
    {
        // PUT Operationalization Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task CreateOrUpdate_PUTOperationalizationCluster()
        {
            // Generated from example definition: specification/machinelearningcompute/resource-manager/Microsoft.MachineLearningCompute/preview/2017-08-01-preview/examples/OperationalizationClusters_CreateOrUpdate.json
            // this example is just showing the usage of "OperationalizationClusters_CreateOrUpdate" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalizationClusterResource
            OperationalizationClusterCollection collection = resourceGroupResource.GetOperationalizationClusters();

            // invoke the operation
            string clusterName = "myCluster";
            OperationalizationClusterData data = new OperationalizationClusterData(new AzureLocation("West US"))
            {
                Description = "My Operationalization Cluster",
                ClusterType = ClusterType.ACS,
                ContainerService = new AcsClusterProperties(OrchestratorType.Kubernetes)
                {
                    OrchestratorServicePrincipal = new ServicePrincipalProperties("abcdefghijklmnopqrt", "<secret>"),
                },
                GlobalServiceConfiguration = new GlobalServiceConfiguration()
                {
                    Ssl = new SslConfiguration()
                    {
                        Status = Status.Enabled,
                        Cert = "afjdklq2131casfakld=",
                        Key = "flksdafkldsajf=",
                        Cname = "foo.bar.com",
                    },
                },
                Tags =
{
["key1"] = "alpha",
["key2"] = "beta",
},
            };
            ArmOperation<OperationalizationClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);
            OperationalizationClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalizationClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GET Operationalization Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Get_GETOperationalizationCluster()
        {
            // Generated from example definition: specification/machinelearningcompute/resource-manager/Microsoft.MachineLearningCompute/preview/2017-08-01-preview/examples/OperationalizationClusters_Get.json
            // this example is just showing the usage of "OperationalizationClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalizationClusterResource
            OperationalizationClusterCollection collection = resourceGroupResource.GetOperationalizationClusters();

            // invoke the operation
            string clusterName = "myCluster";
            OperationalizationClusterResource result = await collection.GetAsync(clusterName);

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            OperationalizationClusterData resourceData = result.Data;
            // for demo we just print out the id
            Console.WriteLine($"Succeeded on id: {resourceData.Id}");
        }

        // GET Operationalization Cluster
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task Exists_GETOperationalizationCluster()
        {
            // Generated from example definition: specification/machinelearningcompute/resource-manager/Microsoft.MachineLearningCompute/preview/2017-08-01-preview/examples/OperationalizationClusters_Get.json
            // this example is just showing the usage of "OperationalizationClusters_Get" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalizationClusterResource
            OperationalizationClusterCollection collection = resourceGroupResource.GetOperationalizationClusters();

            // invoke the operation
            string clusterName = "myCluster";
            bool result = await collection.ExistsAsync(clusterName);

            Console.WriteLine($"Succeeded: {result}");
        }

        // List Operationalization Clusters by Resource Group
        [NUnit.Framework.Test]
        [NUnit.Framework.Ignore("Only verifying that the sample builds")]
        public async Task GetAll_ListOperationalizationClustersByResourceGroup()
        {
            // Generated from example definition: specification/machinelearningcompute/resource-manager/Microsoft.MachineLearningCompute/preview/2017-08-01-preview/examples/OperationalizationClusters_ListByResourceGroup.json
            // this example is just showing the usage of "OperationalizationClusters_ListByResourceGroup" operation, for the dependent resources, they will have to be created separately.

            // get your azure access token, for more details of how Azure SDK get your access token, please refer to https://learn.microsoft.com/en-us/dotnet/azure/sdk/authentication?tabs=command-line
            TokenCredential cred = new DefaultAzureCredential();
            // authenticate your client
            ArmClient client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            string subscriptionId = "00000000-0000-0000-0000-000000000000";
            string resourceGroupName = "myResourceGroup";
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this OperationalizationClusterResource
            OperationalizationClusterCollection collection = resourceGroupResource.GetOperationalizationClusters();

            // invoke the operation and iterate over the result
            await foreach (OperationalizationClusterResource item in collection.GetAllAsync())
            {
                // the variable item is a resource, you could call other operations on this instance as well
                // but just for demo, we get its data from this resource instance
                OperationalizationClusterData resourceData = item.Data;
                // for demo we just print out the id
                Console.WriteLine($"Succeeded on id: {resourceData.Id}");
            }

            Console.WriteLine($"Succeeded");
        }
    }
}
