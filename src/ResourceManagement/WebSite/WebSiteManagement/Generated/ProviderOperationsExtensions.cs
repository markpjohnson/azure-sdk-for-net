// Code generated by Microsoft (R) AutoRest Code Generator 0.11.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;

    public static partial class ProviderOperationsExtensions
    {
            /// <summary>
            /// Gets the source controls available for Azure websites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static SourceControlCollection GetSourceControls(this IProviderOperations operations)
            {
                return Task.Factory.StartNew(s => ((IProviderOperations)s).GetSourceControlsAsync(), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the source controls available for Azure websites
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SourceControlCollection> GetSourceControlsAsync( this IProviderOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SourceControlCollection> result = await operations.GetSourceControlsWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets source control token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            public static SourceControl GetSourceControl(this IProviderOperations operations, string sourceControlType)
            {
                return Task.Factory.StartNew(s => ((IProviderOperations)s).GetSourceControlAsync(sourceControlType), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets source control token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SourceControl> GetSourceControlAsync( this IProviderOperations operations, string sourceControlType, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SourceControl> result = await operations.GetSourceControlWithHttpMessagesAsync(sourceControlType, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Updates source control token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            /// <param name='requestMessage'>
            /// Source control token information
            /// </param>
            public static SourceControl UpdateSourceControl(this IProviderOperations operations, string sourceControlType, SourceControl requestMessage)
            {
                return Task.Factory.StartNew(s => ((IProviderOperations)s).UpdateSourceControlAsync(sourceControlType, requestMessage), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates source control token
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='sourceControlType'>
            /// Type of source control
            /// </param>
            /// <param name='requestMessage'>
            /// Source control token information
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SourceControl> UpdateSourceControlAsync( this IProviderOperations operations, string sourceControlType, SourceControl requestMessage, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<SourceControl> result = await operations.UpdateSourceControlWithHttpMessagesAsync(sourceControlType, requestMessage, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Gets publishing user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of user
            /// </param>
            public static User GetPublishingUser(this IProviderOperations operations, string name)
            {
                return Task.Factory.StartNew(s => ((IProviderOperations)s).GetPublishingUserAsync(name), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets publishing user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> GetPublishingUserAsync( this IProviderOperations operations, string name, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<User> result = await operations.GetPublishingUserWithHttpMessagesAsync(name, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

            /// <summary>
            /// Updates publishing user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of user
            /// </param>
            /// <param name='requestMessage'>
            /// Details of publishing user
            /// </param>
            public static User UpdatePublishingUser(this IProviderOperations operations, string name, User requestMessage)
            {
                return Task.Factory.StartNew(s => ((IProviderOperations)s).UpdatePublishingUserAsync(name, requestMessage), operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Updates publishing user
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='name'>
            /// Name of user
            /// </param>
            /// <param name='requestMessage'>
            /// Details of publishing user
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<User> UpdatePublishingUserAsync( this IProviderOperations operations, string name, User requestMessage, CancellationToken cancellationToken = default(CancellationToken))
            {
                AzureOperationResponse<User> result = await operations.UpdatePublishingUserWithHttpMessagesAsync(name, requestMessage, null, cancellationToken).ConfigureAwait(false);
                return result.Body;
            }

    }
}
