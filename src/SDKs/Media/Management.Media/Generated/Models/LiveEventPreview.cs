// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Media.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The Live Event preview.
    /// </summary>
    public partial class LiveEventPreview
    {
        /// <summary>
        /// Initializes a new instance of the LiveEventPreview class.
        /// </summary>
        public LiveEventPreview()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the LiveEventPreview class.
        /// </summary>
        /// <param name="endpoints">The endpoints for preview.</param>
        /// <param name="accessControl">The access control for LiveEvent
        /// preview.</param>
        /// <param name="previewLocator">The preview locator Guid.</param>
        /// <param name="streamingPolicyName">The name of streaming policy used
        /// for LiveEvent preview</param>
        /// <param name="alternativeMediaId">An Alternative Media Identifier
        /// associated with the preview url.  This identifier can be used to
        /// distinguish the preview of different live events for authorization
        /// purposes in the CustomLicenseAcquisitionUrlTemplate or the
        /// CustomKeyAcquisitionUrlTemplate of the StreamingPolicy specified in
        /// the StreamingPolicyName field.</param>
        public LiveEventPreview(IList<LiveEventEndpoint> endpoints = default(IList<LiveEventEndpoint>), LiveEventPreviewAccessControl accessControl = default(LiveEventPreviewAccessControl), string previewLocator = default(string), string streamingPolicyName = default(string), string alternativeMediaId = default(string))
        {
            Endpoints = endpoints;
            AccessControl = accessControl;
            PreviewLocator = previewLocator;
            StreamingPolicyName = streamingPolicyName;
            AlternativeMediaId = alternativeMediaId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the endpoints for preview.
        /// </summary>
        [JsonProperty(PropertyName = "endpoints")]
        public IList<LiveEventEndpoint> Endpoints { get; set; }

        /// <summary>
        /// Gets or sets the access control for LiveEvent preview.
        /// </summary>
        [JsonProperty(PropertyName = "accessControl")]
        public LiveEventPreviewAccessControl AccessControl { get; set; }

        /// <summary>
        /// Gets or sets the preview locator Guid.
        /// </summary>
        [JsonProperty(PropertyName = "previewLocator")]
        public string PreviewLocator { get; set; }

        /// <summary>
        /// Gets or sets the name of streaming policy used for LiveEvent
        /// preview
        /// </summary>
        [JsonProperty(PropertyName = "streamingPolicyName")]
        public string StreamingPolicyName { get; set; }

        /// <summary>
        /// Gets or sets an Alternative Media Identifier associated with the
        /// preview url.  This identifier can be used to distinguish the
        /// preview of different live events for authorization purposes in the
        /// CustomLicenseAcquisitionUrlTemplate or the
        /// CustomKeyAcquisitionUrlTemplate of the StreamingPolicy specified in
        /// the StreamingPolicyName field.
        /// </summary>
        [JsonProperty(PropertyName = "alternativeMediaId")]
        public string AlternativeMediaId { get; set; }

    }
}