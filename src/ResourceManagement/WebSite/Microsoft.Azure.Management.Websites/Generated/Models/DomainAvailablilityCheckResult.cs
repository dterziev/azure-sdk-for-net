// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.WebSites.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Domain availablility check result
    /// </summary>
    public partial class DomainAvailablilityCheckResult
    {
        /// <summary>
        /// Initializes a new instance of the DomainAvailablilityCheckResult
        /// class.
        /// </summary>
        public DomainAvailablilityCheckResult() { }

        /// <summary>
        /// Initializes a new instance of the DomainAvailablilityCheckResult
        /// class.
        /// </summary>
        public DomainAvailablilityCheckResult(string name = default(string), bool? available = default(bool?), DomainType? domainType = default(DomainType?))
        {
            Name = name;
            Available = available;
            DomainType = domainType;
        }

        /// <summary>
        /// Name of the domain
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// If true then domain can be purchased using CreateDomain Api
        /// </summary>
        [JsonProperty(PropertyName = "available")]
        public bool? Available { get; set; }

        /// <summary>
        /// Domain type. Possible values include: 'Regular', 'SoftDeleted'
        /// </summary>
        [JsonProperty(PropertyName = "domainType")]
        public DomainType? DomainType { get; set; }

    }
}