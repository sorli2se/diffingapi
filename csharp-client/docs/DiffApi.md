# IO.Swagger.Api.DiffApi

All URIs are relative to *http://localhost/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDiff**](DiffApi.md#getdiff) | **GET** /diff/{diffId}/ | get status of diff


<a name="getdiff"></a>
# **GetDiff**
> ResponseBody GetDiff (long? diffId)

get status of diff

### Example
```csharp
using System;
using System.Diagnostics;
using IO.Swagger.Api;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace Example
{
    public class GetDiffExample
    {
        public void main()
        {
            var apiInstance = new DiffApi();
            var diffId = 789;  // long? | ID of content to update

            try
            {
                // get status of diff
                ResponseBody result = apiInstance.GetDiff(diffId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DiffApi.GetDiff: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **diffId** | **long?**| ID of content to update | 

### Return type

[**ResponseBody**](ResponseBody.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

