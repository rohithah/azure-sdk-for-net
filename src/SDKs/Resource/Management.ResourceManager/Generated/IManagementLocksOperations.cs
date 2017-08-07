// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager
{
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// ManagementLocksOperations operations.
    /// </summary>
    public partial interface IManagementLocksOperations
    {
        /// <summary>
        /// Creates or updates a management lock at the resource group level.
        /// </summary>
        /// <remarks>
        /// When you apply a lock at a parent scope, all child resources
        /// inherit the same lock. To create management locks, you must have
        /// access to Microsoft.Authorization/* or
        /// Microsoft.Authorization/locks/* actions. Of the built-in roles,
        /// only Owner and User Access Administrator are granted those
        /// actions.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group to lock.
        /// </param>
        /// <param name='lockName'>
        /// The lock name. The lock name can be a maximum of 260 characters.
        /// It cannot contain &lt;, &gt; %, &amp;, :, \, ?, /, or any control
        /// characters.
        /// </param>
        /// <param name='parameters'>
        /// The management lock parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> CreateOrUpdateAtResourceGroupLevelWithHttpMessagesAsync(string resourceGroupName, string lockName, ManagementLockObject parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes a management lock at the resource group level.
        /// </summary>
        /// <remarks>
        /// To delete management locks, you must have access to
        /// Microsoft.Authorization/* or Microsoft.Authorization/locks/*
        /// actions. Of the built-in roles, only Owner and User Access
        /// Administrator are granted those actions.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the lock.
        /// </param>
        /// <param name='lockName'>
        /// The name of lock to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteAtResourceGroupLevelWithHttpMessagesAsync(string resourceGroupName, string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a management lock at the resource group level.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the locked resource group.
        /// </param>
        /// <param name='lockName'>
        /// The name of the lock to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> GetAtResourceGroupLevelWithHttpMessagesAsync(string resourceGroupName, string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Create or update a management lock by scope.
        /// </summary>
        /// <param name='scope'>
        /// The scope for the lock. When providing a scope for the assignment,
        /// use '/subscriptions/{subscriptionId}' for subscriptions,
        /// '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}'
        /// for resource groups, and
        /// '/subscriptions/{subscriptionId}/resourcegroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{parentResourcePathIfPresent}/{resourceType}/{resourceName}'
        /// for resources.
        /// </param>
        /// <param name='lockName'>
        /// The name of lock.
        /// </param>
        /// <param name='parameters'>
        /// Create or update management lock parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> CreateOrUpdateByScopeWithHttpMessagesAsync(string scope, string lockName, ManagementLockObject parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Delete a management lock by scope.
        /// </summary>
        /// <param name='scope'>
        /// The scope for the lock.
        /// </param>
        /// <param name='lockName'>
        /// The name of lock.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteByScopeWithHttpMessagesAsync(string scope, string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get a management lock by scope.
        /// </summary>
        /// <param name='scope'>
        /// The scope for the lock.
        /// </param>
        /// <param name='lockName'>
        /// The name of lock.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> GetByScopeWithHttpMessagesAsync(string scope, string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates or updates a management lock at the resource level or any
        /// level below the resource.
        /// </summary>
        /// <remarks>
        /// When you apply a lock at a parent scope, all child resources
        /// inherit the same lock. To create management locks, you must have
        /// access to Microsoft.Authorization/* or
        /// Microsoft.Authorization/locks/* actions. Of the built-in roles,
        /// only Owner and User Access Administrator are granted those
        /// actions.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource to lock.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The resource provider namespace of the resource to lock.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the resource to lock.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource to lock.
        /// </param>
        /// <param name='lockName'>
        /// The name of lock. The lock name can be a maximum of 260
        /// characters. It cannot contain &lt;, &gt; %, &amp;, :, \, ?, /, or
        /// any control characters.
        /// </param>
        /// <param name='parameters'>
        /// Parameters for creating or updating a  management lock.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> CreateOrUpdateAtResourceLevelWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string lockName, ManagementLockObject parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes the management lock of a resource or any level below the
        /// resource.
        /// </summary>
        /// <remarks>
        /// To delete management locks, you must have access to
        /// Microsoft.Authorization/* or Microsoft.Authorization/locks/*
        /// actions. Of the built-in roles, only Owner and User Access
        /// Administrator are granted those actions.
        /// </remarks>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the resource with the
        /// lock to delete.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The resource provider namespace of the resource with the lock to
        /// delete.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the resource with the lock to delete.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource with the lock to delete.
        /// </param>
        /// <param name='lockName'>
        /// The name of the lock to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteAtResourceLevelWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Get the management lock of a resource or any level below resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// An extra path parameter needed in some services, like SQL
        /// Databases.
        /// </param>
        /// <param name='resourceType'>
        /// The type of the resource.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the resource.
        /// </param>
        /// <param name='lockName'>
        /// The name of lock.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> GetAtResourceLevelWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Creates or updates a management lock at the subscription level.
        /// </summary>
        /// <remarks>
        /// When you apply a lock at a parent scope, all child resources
        /// inherit the same lock. To create management locks, you must have
        /// access to Microsoft.Authorization/* or
        /// Microsoft.Authorization/locks/* actions. Of the built-in roles,
        /// only Owner and User Access Administrator are granted those
        /// actions.
        /// </remarks>
        /// <param name='lockName'>
        /// The name of lock. The lock name can be a maximum of 260
        /// characters. It cannot contain &lt;, &gt; %, &amp;, :, \, ?, /, or
        /// any control characters.
        /// </param>
        /// <param name='parameters'>
        /// The management lock parameters.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> CreateOrUpdateAtSubscriptionLevelWithHttpMessagesAsync(string lockName, ManagementLockObject parameters, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Deletes the management lock at the subscription level.
        /// </summary>
        /// <remarks>
        /// To delete management locks, you must have access to
        /// Microsoft.Authorization/* or Microsoft.Authorization/locks/*
        /// actions. Of the built-in roles, only Owner and User Access
        /// Administrator are granted those actions.
        /// </remarks>
        /// <param name='lockName'>
        /// The name of lock to delete.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse> DeleteAtSubscriptionLevelWithHttpMessagesAsync(string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets a management lock at the subscription level.
        /// </summary>
        /// <param name='lockName'>
        /// The name of the lock to get.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<ManagementLockObject>> GetAtSubscriptionLevelWithHttpMessagesAsync(string lockName, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets all the management locks for a resource group.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the locks to get.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ManagementLockObject>>> ListAtResourceGroupLevelWithHttpMessagesAsync(string resourceGroupName, Microsoft.Rest.Azure.OData.ODataQuery<ManagementLockObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ManagementLockObject>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets all the management locks for a resource or any level below
        /// resource.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the resource group containing the locked resource. The
        /// name is case insensitive.
        /// </param>
        /// <param name='resourceProviderNamespace'>
        /// The namespace of the resource provider.
        /// </param>
        /// <param name='parentResourcePath'>
        /// The parent resource identity.
        /// </param>
        /// <param name='resourceType'>
        /// The resource type of the locked resource.
        /// </param>
        /// <param name='resourceName'>
        /// The name of the locked resource.
        /// </param>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ManagementLockObject>>> ListAtResourceLevelWithHttpMessagesAsync(string resourceGroupName, string resourceProviderNamespace, string parentResourcePath, string resourceType, string resourceName, Microsoft.Rest.Azure.OData.ODataQuery<ManagementLockObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ManagementLockObject>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets all the management locks for a subscription.
        /// </summary>
        /// <param name='odataQuery'>
        /// OData parameters to apply to the operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ManagementLockObject>>> ListAtSubscriptionLevelWithHttpMessagesAsync(Microsoft.Rest.Azure.OData.ODataQuery<ManagementLockObject> odataQuery = default(Microsoft.Rest.Azure.OData.ODataQuery<ManagementLockObject>), System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets all the management locks for a resource group.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ManagementLockObject>>> ListAtResourceGroupLevelNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets all the management locks for a resource or any level below
        /// resource.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ManagementLockObject>>> ListAtResourceLevelNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Gets all the management locks for a subscription.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.Azure.CloudException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        System.Threading.Tasks.Task<Microsoft.Rest.Azure.AzureOperationResponse<Microsoft.Rest.Azure.IPage<ManagementLockObject>>> ListAtSubscriptionLevelNextWithHttpMessagesAsync(string nextPageLink, System.Collections.Generic.Dictionary<string, System.Collections.Generic.List<string>> customHeaders = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
    }
}