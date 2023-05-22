// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
using Azure.Identity;
using Azure.ResourceManager.Resources;
using Azure.ResourceManager.ServiceFabricManagedClusters.Models;
using Azure.ResourceManager.TestFramework;
using NUnit.Framework;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Tests
{
    public class ServiceFabricManagedClustersManagementTestBase : ManagementRecordedTestBase<ServiceFabricManagedClustersManagementTestEnvironment>
    {
        public ServiceFabricManagedClusterCollection collection { get; set; }
        public string clusterName = "sfmctestcluster";
        public ArmClient client { get; set; }
        public const string subscriptionId = "13ad2c84-84fa-4798-ad71-e70c07af873f";
        public const string resourceGroupName = "rg-mwesigwagumaazureresourcemanagerservicefabricmanagedclusters";
        protected ServiceFabricManagedClustersManagementTestBase(bool isAsync, RecordedTestMode mode)
        : base(isAsync, mode)
        {
            Console.WriteLine($"test mode is: {mode}");
        }

        protected ServiceFabricManagedClustersManagementTestBase(bool isAsync)
            : base(isAsync)
        {
            Console.WriteLine("Executing SfmcTestBase constructor");
        }

        public async void createClusterResource()
        {
            Console.WriteLine("Executing creatClusterResource function");
            TokenCredential cred = new DefaultAzureCredential();

            client = new ArmClient(cred);

            // this example assumes you already have this ResourceGroupResource created on azure
            // for more information of creating ResourceGroupResource, please refer to the document of ResourceGroupResource
            ResourceIdentifier resourceGroupResourceId = ResourceGroupResource.CreateResourceIdentifier(subscriptionId, resourceGroupName);
            ResourceGroupResource resourceGroupResource = client.GetResourceGroupResource(resourceGroupResourceId);

            // get the collection of this ServiceFabricManagedClusterResource
            collection = resourceGroupResource.GetServiceFabricManagedClusters();
            ServiceFabricManagedClusterData data = new ServiceFabricManagedClusterData(new AzureLocation("southcentralus"))
            {
                DnsName = clusterName,
                AdminUserName = "Myusername4",
                AdminPassword = "Sfmcpass5!",
                Sku = new ServiceFabricManagedClustersSku(ServiceFabricManagedClustersSkuName.Standard),
                ClientConnectionPort = 19000,
                HttpGatewayConnectionPort = 19080
            };

            ResourceIdentifier serviceFabricManagedClusterResourceId = ServiceFabricManagedClusterResource.CreateResourceIdentifier(subscriptionId, resourceGroupName, clusterName);
            ServiceFabricManagedClusterResource serviceFabricManagedCluster = client.GetServiceFabricManagedClusterResource(serviceFabricManagedClusterResourceId);
            ArmOperation<ServiceFabricManagedClusterResource> lro = await collection.CreateOrUpdateAsync(WaitUntil.Completed, clusterName, data);

            ServiceFabricManagedNodeTypeCollection nodeTypeCollection = serviceFabricManagedCluster.GetServiceFabricManagedNodeTypes();

            string nodeTypeName = "nodetype1";
            ServiceFabricManagedNodeTypeData nodeTypeData = new ServiceFabricManagedNodeTypeData()
            {
                IsPrimary = true,
                VmInstanceCount = 5,
                DataDiskSizeInGB = 100,
                VmSize = "Standard_D2s_v3",
                VmImagePublisher = "MicrosoftWindowsServer",
                VmImageOffer = "WindowsServer",
                VmImageSku = "2022-Datacenter",
                VmImageVersion = "latest",
            };

            ArmOperation<ServiceFabricManagedNodeTypeResource> lroNodeType = await nodeTypeCollection.CreateOrUpdateAsync(WaitUntil.Completed, nodeTypeName, nodeTypeData);

            /*ServiceFabricManagedClusterResource result = lro.Value;

            // the variable result is a resource, you could call other operations on this instance as well
            // but just for demo, we get its data from this resource instance
            ServiceFabricManagedClusterData resourceData = result.Data;*/
        }
    }
}
