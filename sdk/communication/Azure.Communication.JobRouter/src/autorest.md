﻿# Azure.Communication.JobRouter

When a new version of the swagger needs to be updated:
1. Go to sdk\communication\Azure.Communication.JobRouter\src, and run `dotnet msbuild /t:GenerateCode` to generate code.
2. Upload the Azure.Communication.JobRouter.dll to the apiview.dev tool.
If any of the new objects needs to be overwritten, add the required changes to the 'Models' folder.

3. Repeat 2 and 3 until the decided interface is reflected in the apiview.dev 

> see [https://aka.ms/autorest](https://aka.ms/autorest)

## Configuration

```yaml
tag: package-jobrouter-2022-07-18-preview
model-namespace: false
require:
    -  https://raw.githubusercontent.com/williamzhao87/azure-rest-api-specs/9d3360a17e766a1833bfda1315d6863ee44e917c/specification/communication/data-plane/JobRouter/readme.md

generation1-convenience-client: true
reflect-api-versions: true
protocol-method-list:
    - JobRouterAdministration_UpsertClassificationPolicy
    - JobRouterAdministration_UpsertDistributionPolicy
    - JobRouterAdministration_UpsertExceptionPolicy
    - JobRouterAdministration_UpsertQueue
    - JobRouter_UpsertJob
    - JobRouter_UpsertWorker

directive:
- rename-model:
    from: ScheduleAndSuspendMode
    to: ScheduleAndSuspendModeInternal
- rename-model:
    from: JobMatchingMode
    to: JobMatchingModeInternal
```
