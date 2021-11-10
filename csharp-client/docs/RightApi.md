# IO.Swagger.Api.RightApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**UpdateRight**](RightApi.md#updateright) | **PUT** /diff/{diffId}/right | Update an right side


<a name="updateright"></a>
# **UpdateRight**
> void UpdateRight (long? diffId, RequestBody body)

Update an right side

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class UpdateRightExample
    {
        public void main()
        {
            var apiInstance = new RightApi();
            var diffId = 789;  // long? | ID of content to update
            var body = new RequestBody(); // RequestBody | Right object that needs to be added for the diff

            try
            {
                // Update an right side
                apiInstance.UpdateRight(diffId, body);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling RightApi.UpdateRight: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diffId** | **long?**| ID of content to update | 
 **body** | [**RequestBody**](RequestBody.md)| Right object that needs to be added for the diff | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

