# IO.Swagger.Api.LeftApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdateLeft**](LeftApi.md#updateleft) | **PUT** /diff/{diffId}/left | Update an left side


<a name="updateleft"></a>
# **UpdateLeft**
> void UpdateLeft (long? diffId, RequestBody body)

Update an left side

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateLeftExample
    {
        public void main()
        {
            var apiInstance = new LeftApi();
            var diffId = 789;  // long? | diff of ID to update
            var body = new RequestBody(); // RequestBody | Left object that needs to be added for the diff

            try
            {
                // Update an left side
                apiInstance.UpdateLeft(diffId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling LeftApi.UpdateLeft: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diffId** | **long?**| diff of ID to update | 
 **body** | [**RequestBody**](RequestBody.md)| Left object that needs to be added for the diff | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

