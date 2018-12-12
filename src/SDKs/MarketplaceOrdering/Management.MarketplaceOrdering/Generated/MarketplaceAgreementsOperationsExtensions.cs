// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.MarketplaceOrdering
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for MarketplaceAgreementsOperations.
    /// </summary>
    public static partial class MarketplaceAgreementsOperationsExtensions
    {
            /// <summary>
            /// Get marketplace terms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='publisherId'>
            /// Publisher identifier string of image being deployed.
            /// </param>
            /// <param name='offerId'>
            /// Offer identifier string of image being deployed.
            /// </param>
            /// <param name='planId'>
            /// Plan identifier string of image being deployed.
            /// </param>
            public static AgreementTerms Get(this IMarketplaceAgreementsOperations operations, string publisherId, string offerId, string planId)
            {
                return operations.GetAsync(publisherId, offerId, planId).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get marketplace terms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='publisherId'>
            /// Publisher identifier string of image being deployed.
            /// </param>
            /// <param name='offerId'>
            /// Offer identifier string of image being deployed.
            /// </param>
            /// <param name='planId'>
            /// Plan identifier string of image being deployed.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgreementTerms> GetAsync(this IMarketplaceAgreementsOperations operations, string publisherId, string offerId, string planId, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(publisherId, offerId, planId, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Save marketplace terms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='publisherId'>
            /// Publisher identifier string of image being deployed.
            /// </param>
            /// <param name='offerId'>
            /// Offer identifier string of image being deployed.
            /// </param>
            /// <param name='planId'>
            /// Plan identifier string of image being deployed.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Marketplace Terms operation.
            /// </param>
            public static AgreementTerms Create(this IMarketplaceAgreementsOperations operations, string publisherId, string offerId, string planId, AgreementTerms parameters)
            {
                return operations.CreateAsync(publisherId, offerId, planId, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Save marketplace terms.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='publisherId'>
            /// Publisher identifier string of image being deployed.
            /// </param>
            /// <param name='offerId'>
            /// Offer identifier string of image being deployed.
            /// </param>
            /// <param name='planId'>
            /// Plan identifier string of image being deployed.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to the Create Marketplace Terms operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgreementTerms> CreateAsync(this IMarketplaceAgreementsOperations operations, string publisherId, string offerId, string planId, AgreementTerms parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(publisherId, offerId, planId, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}