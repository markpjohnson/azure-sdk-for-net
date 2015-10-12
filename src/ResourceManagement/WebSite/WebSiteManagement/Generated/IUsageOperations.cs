// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    /// <summary>
    /// UsageOperations operations.
    /// </summary>
    public partial interface IUsageOperations
    {
        /// <summary>
        /// Returns usage records for specified subscription and resource
        /// groups
        /// </summary>
        /// <param name='resourceGroupName'>
        /// Name of resource group
        /// </param>
        /// <param name='environmentName'>
        /// Environment name
        /// </param>
        /// <param name='lastId'>
        /// Last marker that was returned from the batch
        /// </param>
        /// <param name='batchSize'>
        /// size of the batch to be returned.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<AzureOperationResponse<object>> GetUsageWithHttpMessagesAsync(string resourceGroupName, string environmentName, string lastId, int? batchSize, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
