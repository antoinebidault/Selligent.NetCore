
[![Build Status](https://dev.azure.com/NGPA/NGPA%20Devops/_apis/build/status/Ngpa.Selligent?branchName=master)](https://dev.azure.com/NGPA/NGPA%20Devops/_build/latest?definitionId=23&branchName=master)

![selligent](selligent.png)

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

 # Sample use (Journey's trigger)
 
 ```CSharp
try
{
  data["MAIL"] = "test@test.com";
  data["ABONNEMENT"] = "1";
  data["API"] = "1";
  data["SOURCE"] ="TEST";
  data["CANAL"] = "1";
  data["MEDIA"] = "MyMedia";

  //  Correspond à la liste d'envoi
  data["THEME"] = member.ListIds.FirstOrDefault() ?? "LMA";



  var response = new CustomClient(_config)
      .TriggerEntryPointAsync(
          "inscription_liste",
          "liste_abo",
          new Trigger_journey_entry_points_request(data, null),
          "ngpa_preprod").Result;

  if (response.Result_code == Trigger_journey_entry_point_responseResult_code.Succeeded || 
      response.Result_code == Trigger_journey_entry_point_responseResult_code.PartiallySucceeded)
  {
    return new MemberCreationResult()
    {
      Success = true
    };
  } else {
    throw new Exception(response.Body);
  }
}
catch (Exception e)
{
  return new MemberCreationResult()
  {
    Success = false,
    Message = e.Message
  };
}
 ```


# Build and Test

Build the solution and go !
