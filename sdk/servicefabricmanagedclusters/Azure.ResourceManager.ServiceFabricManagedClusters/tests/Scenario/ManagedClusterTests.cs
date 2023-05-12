// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.TestFramework;
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
        public void clusterTest()
        {
            var clusterResource = createClusterResource();
            Assert.NotNull(clusterResource);
        }
    }
}
