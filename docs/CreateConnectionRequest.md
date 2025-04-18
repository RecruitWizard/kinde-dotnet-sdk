# Kinde.Api.Model.CreateConnectionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The internal name of the connection. | [optional] 
**DisplayName** | **string** | The public facing name of the connection. | [optional] 
**Strategy** | **string** | The identity provider identifier for the connection. | [optional] 
**EnabledApplications** | **List&lt;string&gt;** | Client IDs of applications in which this connection is to be enabled. | [optional] 
**OrganizationCode** | **string** | Enterprise connections only - the code for organization that manages this connection. | [optional] 
**Options** | [**CreateConnectionRequestOptions**](CreateConnectionRequestOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

