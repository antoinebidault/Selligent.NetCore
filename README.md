
[![Build Status](https://dev.azure.com/NGPA/NGPA%20Devops/_apis/build/status/Ngpa.Selligent?branchName=master)](https://dev.azure.com/NGPA/NGPA%20Devops/_build/latest?definitionId=23&branchName=master)

!(selligent)[./selligent.png]

# Introduction

The purpose of this library is to porvide a reliable .Net core REST Client for Selligent

# Available clients

- MediumClient
- NotificationGroupClient
- OrganizationClient
- ContentClient
- DataExportClient
- DataImportClient
- JourneyClient
- ABClient
- CustomeClient
- RecurringCliennt
- SingleBatchClient
- TransactionalClient
- TransactionalBulkClient
- TransactionalShortcutClient
- ListClient
- DataClient
- TaskClient
- StatusClient
- StoredProcedureClient

# Simple us case

```CSharp
var client = new MediumClient(new SelligentClientConfiguration(){
 BaseUrl = "{Paste your api url here e.g. https://yourapi.com/Api/ }",
 PublicKey = "{Your API key}",
 PrivateKey = "{Your API secret key}",
});

var dataFromApi = await client.GetMediumsAsync();

```

# Build and Test

Build the solution and go !